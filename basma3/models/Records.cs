//????????????????using basma3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basma2.models
{
    public class Records
    {

        public Records()
        {

        }
        public Records(DateTime day, int empId, DateTime? attendence, DateTime? departure)
        {
            this.Attendence = attendence;
            this.departure = departure;
            this.day = day;
            this.empId = empId;

        }
        public Records(DateTime day, int empId)
        {
            this.day = day;
            this.empId = empId;
        }

        [Key]
        public int recordId { get; set; }
        public DateTime? Attendence { get; set; }
        public DateTime? departure { get; set; }

        public DateTime day { get; set; }

        [ForeignKey("Employee")]
        public int empId { get; set; }


        //nav
        public virtual Employee Employee { get; set; }



    }
}
