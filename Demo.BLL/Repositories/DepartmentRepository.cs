using Demo.BLL.InterFaces;
using DemoDAL.Context;
using DemoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>,IDepartmentRepository
    {
        private readonly MvcAppGo3DbContext _dbContext;

        public DepartmentRepository(MvcAppGo3DbContext dbContext):base(dbContext)
        {
           _dbContext = dbContext;
        }
    }
}
