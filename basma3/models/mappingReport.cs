using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basma3.models
{
    internal class mappingReport
    {


        public int recordId { get; set; }
        public string name { get; set; }
        public DateTime? Attendence { get; set; }
        public DateTime? departure { get; set; }

        public DateTime day { get; set; }

        public int empId { get; set; }

    }
}
