﻿using Demo.BLL.InterFaces;
using DemoDAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly MvcAppGo3DbContext _dbContext;

        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }

        public UnitOfWork(MvcAppGo3DbContext dbContext)
        {
            EmployeeRepository = new EmployeeRepository(dbContext);
            DepartmentRepository = new DepartmentRepository(dbContext);
            _dbContext = dbContext;
        }

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
           _dbContext.Dispose();

        }
    }
}
