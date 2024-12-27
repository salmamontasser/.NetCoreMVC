
using AutoMapper;
using Demo.BLL.InterFaces;
using Demo.BLL.Repositories;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using DemoDAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
	[Authorize]
	public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _maps;

        public EmployeeController(IUnitOfWork unitOfWork,
            IMapper maps)// Ask CLR for Creating Object From class Implement IEmployeeRepository
        {

            _unitOfWork = unitOfWork;
            _maps = maps;
        }
        public async Task<IActionResult> Index(string SearchValue)
        {
            IEnumerable<Employee> employees;
            if (string.IsNullOrEmpty(SearchValue))
            {

                employees =await _unitOfWork.EmployeeRepository.GetAllAsync();

            }
            else 
            {
                employees = _unitOfWork.EmployeeRepository.GetEmployeesByName(SearchValue);
            }
                var MappedEmployee=_maps.Map<IEnumerable<Employee>,IEnumerable<EmployeeViewModel>>(employees);
                return View(MappedEmployee);
            /// 1.ViewData =>KeyValue[dicionary Object]
            /// Transfer Data From Controller [Action ] To its view
            /// .NetFrameWork 3.5
            ///ViewData["Message"] = "hello From view Data";
            /// 2. ViewBag => Dynamic Property [Based on Dynamic Keyword
            /// Transfer Data From Controller [Action ] To its view
            /// .NetFrameWork 4.0
            /// ViewBag.Message = "hello From view Bag";

        }
        public IActionResult Create()
        {
           // ViewBag.Departments = _departmentRepository.GetAll();
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                ///var MappedEmployee =new Employee()
                ///{
                ///    Name=employeeVM.Name,
                ///    Age=employeeVM.Age,
                ///    Address=employeeVM.Address,
                ///    Salary=employeeVM.Salary,
                ///};
                ///Employee employee = (Employee) employeeVM;
                ///

                employeeVM.ImageName =  DocumentSettings.Uploadfile(employeeVM.Image,"Image");
                
                var MappedEmployee = _maps.Map<EmployeeViewModel, Employee>(employeeVM);
                await _unitOfWork.EmployeeRepository.AddAsync(MappedEmployee);
                ///1.Update
                ///2.Delete
                ///3.Update
                ///_dbContext.Set<T>.add();
                ///_dbContext.SaveChange();
                var Result =await _unitOfWork.CompleteAsync();
                //_dbContext.Dispose();
                if (Result > 0)
                {
                    TempData["Message"] = "Employee Is Created";
                }
                return RedirectToAction(nameof(Index));

            }
            return View(employeeVM);
        }
        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (id is null)
                return BadRequest();//status Code 400
            var employee =await _unitOfWork.EmployeeRepository.GetByIdAsync(id.Value);
            if (employee is null)
                return NotFound();
            var MappedEmployee =_maps.Map<Employee, EmployeeViewModel>(employee);
            return View(ViewName, MappedEmployee);
        }
        [HttpGet]
        public Task<IActionResult> Edit(int? id)
        {
            return Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeViewModel employeeVM, [FromRoute] int id, string ViewName = "Edit")
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    if(employeeVM.Image is not null)
                    {
                        employeeVM.ImageName = DocumentSettings.Uploadfile(employeeVM.Image, "Image");
                    }
                    var MappedEmployee = _maps.Map<EmployeeViewModel,Employee>(employeeVM);
                    _unitOfWork.EmployeeRepository.Update(MappedEmployee);
                  await  _unitOfWork.CompleteAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch(System.Exception ex) 
                { 
                    ModelState.AddModelError(string.Empty,ex.Message);
                }
            }
            return View(ViewName, employeeVM);
        }
        [HttpGet]
        public Task<IActionResult> Delete(int id)
        {
            return Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(EmployeeViewModel employeeVM, [FromRoute] int id)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var MappedEmployee = _maps.Map<EmployeeViewModel, Employee>(employeeVM);
                    _unitOfWork.EmployeeRepository.Delete(MappedEmployee);
                  int Result=await  _unitOfWork.CompleteAsync();
                    if(Result > 0 && employeeVM.ImageName is not null)
                    {
                        DocumentSettings.DeleteFile(employeeVM.ImageName, "Image");
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(employeeVM);

        }
    }
}
