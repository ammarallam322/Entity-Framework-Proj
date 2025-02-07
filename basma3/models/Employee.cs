//?using basma3.models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basma2.models
{
    public class Employee
    {
        public Employee( string name, string email, string password,int did,int age,string role="user")
        {
            Name = name;
            Email = email;
            Password = password;
            this.did = did;
            this.Age = age;
            Role = role;

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(30, MinimumLength = 10)]
        public string Password { get; set; }
        [NotMapped]
        public string PasswordConfirm { get; set; }
        public string Role { get; set; }

        public int Age { get; set; }


        public int? superId { get; set; }  // nullable to make it optional
        public virtual Employee supervisor { get; set; }
        [ForeignKey("department")]
        public int did { get; set; }
        public virtual Department department { get; set; }





        //// navigation properties

       public virtual List<Records> Records { get; set; }
    }






    //public enum ReportType
    //{
    //    daily = 1,
    //    weekly = 7,
    //    monthly=30,
    //    quarterAnnually = 90,
    //    halfAnnually = 180,
    //    anually = 360,






        
    //}
    
}
