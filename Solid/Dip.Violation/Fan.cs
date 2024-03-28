using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Violation
{
    public class Fan : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Fan turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Fan turned on.");
        }
    }
}
