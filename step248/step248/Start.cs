using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step248
{
    public class Start
    {
        [Required]
        public int StartID { get; set; }
        [Required]
        public int LocationID { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        public double HourlyWage { get; set; }

        public virtual Location Location { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
