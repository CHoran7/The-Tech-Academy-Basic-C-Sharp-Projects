using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_162
{
    public class twoConstructors
    {
        public twoConstructors(string time) : this(time, 5)
        {

        }
        public twoConstructors(string time, int distance)
        {
            Miles = distance;
            Time = time;
        }
        public int Miles { get; set; }
        public string Time { get; set; }
    }
}
