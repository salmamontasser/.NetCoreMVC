using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Models
{
    public class Department
    {
        public int Id { get; set; }//PK
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } //Nvchar(50)  not allow Null
        [Required]
        public string Code { get; set; }
        public DateTime DateOfCreation { get; set; }

        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
