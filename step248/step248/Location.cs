using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step248
{
    public class Location
    {
        [Required]
        public int LocationID { get; set; }
        public string Address { get; set; }
        
        public string HomeOwner { get; set; }

        public virtual ICollection<Start> Starts { get; set; }
    }
}
