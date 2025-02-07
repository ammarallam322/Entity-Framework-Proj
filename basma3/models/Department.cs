using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basma2.models
{
    public class Department
    {
        public Department()
        {
            
        }
        public Department( string name)
        {
            this.Name = name;

        }
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        public string manager { get; set; }

       // [ForeignKey("manager")]
        //public int mngId { get; set; }
        //public Employee manager { get; set; }
        
        public virtual List<Employee> Employees { get; set; }

    }
}
