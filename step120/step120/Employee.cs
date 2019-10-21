using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step120
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Employee:");
            base.SayName();
        }
        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
