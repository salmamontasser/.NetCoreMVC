﻿using Demo.BLL.InterFaces;
using DemoDAL.Context;
using DemoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly MvcAppGo3DbContext _dbContext;

        public EmployeeRepository(MvcAppGo3DbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Employee> GetEmployeesByAddress(string address)
        {
          return  _dbContext.Employees.Where(E => E.Address == address);
          
        }

        public IQueryable<Employee> GetEmployeesByName(string SearchValue)
        {
             return   _dbContext.Employees.Where(E=>E.Name.ToLower().Contains(SearchValue.ToLower()));
        }
    }
}
