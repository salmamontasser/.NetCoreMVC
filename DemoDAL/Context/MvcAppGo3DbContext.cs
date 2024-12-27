using DemoDAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Context
{
    public class MvcAppGo3DbContext : IdentityDbContext<ApplicationUser>
    {
        public MvcAppGo3DbContext(DbContextOptions<MvcAppGo3DbContext> options):base(options)
        {
                
        } 
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server = . ; Database = McvAppG03Db ; Trusted_Connection = true ;");
        

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


    }
}
