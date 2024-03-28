using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Violation
{
    public class LightBulb : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Light bulb turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Light bulb turned on.");
        }
    }
}
