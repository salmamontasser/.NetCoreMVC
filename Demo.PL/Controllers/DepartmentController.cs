using AutoMapper;
using Demo.BLL.InterFaces;
using Demo.BLL.Repositories;
using Demo.PL.ViewModels;
using DemoDAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _maps;

        public DepartmentController(IUnitOfWork unitOfWork, IMapper maps) //Ask CLR for Careating Object from Class Implement Interface
        {
            _unitOfWork = unitOfWork;
            _maps = maps;
        }
        // BasiURL/Department/Index
        public async Task<IActionResult> Index()
        {
             IEnumerable<Department> departments;
            departments = await _unitOfWork.DepartmentRepository.GetAllAsync();
            var MappedDepartment = _maps.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
        
            return View(MappedDepartment);
        }

        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentViewModel departmentVM) 
        {
            if (ModelState.IsValid) //server side validation
            {
                var MappedDepartmen=_maps.Map<DepartmentViewModel,Department>(departmentVM);
                await _unitOfWork.DepartmentRepository.AddAsync(MappedDepartmen);
                int Result =await _unitOfWork.CompleteAsync();

                //3. Temp Data -> Dicionary Object
                // Transfer Data from action To action
                if (Result > 0)
                { 
                    TempData["Message"] = "Department Is Created";
                }
                return RedirectToAction(nameof(Index));

            }
            return View(departmentVM);
        }
        //BaseURL/Department/Details/100
        public async Task<IActionResult> Details(int? id ,string ViewName="Details")
        { 
            if(id is null)
                return BadRequest();//status Code 400
            var department = await _unitOfWork.DepartmentRepository.GetByIdAsync(id.Value);
            if(department is null)
                return NotFound();
            var MappedDepartment = _maps.Map<Department, DepartmentViewModel>(department);

            return View(ViewName,MappedDepartment);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id) 
        { 
            //if(id is null)
            //    return BadRequest();
            //var department =_departmentRepository.GetById(id.Value);
            //if (department is null)
            //    return NotFound();
            //return View(department);
            return await Details(id,"Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DepartmentViewModel departmentVM,[FromRoute]int id,string ViewName="Edit") 
        {
            if(id != departmentVM.Id)
                return BadRequest();
            if (ModelState.IsValid) 
            {
                try
                {
                    var MappedDepartment=_maps.Map<DepartmentViewModel,Department>(departmentVM);
                    _unitOfWork.DepartmentRepository.Update(MappedDepartment);
                   await _unitOfWork.CompleteAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch(System.Exception ex)
                {
                    //1. Log Exception
                    //2. Form
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(ViewName,departmentVM);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id) 
        {
            return await Details(id,"Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DepartmentViewModel departmentVM, [FromRoute] int id)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var MappedDepartment = _maps.Map<DepartmentViewModel, Department>(departmentVM);
                    _unitOfWork.DepartmentRepository.Delete(MappedDepartment);
                   await _unitOfWork.CompleteAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (System.Exception ex)
                {
                    //1. Log Exception
                    //2. Form
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(departmentVM);

        }

    }
}
