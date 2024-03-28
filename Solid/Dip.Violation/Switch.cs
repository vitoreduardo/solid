using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Violation
{
    public class Switch
    {
        private LightBulb _lightBulb;
        private Fan _fan;

        public Switch()
        {
            _lightBulb = new LightBulb();
            _fan = new Fan();
        }

        public void TurnOnAllDevices()
        {
            _lightBulb.TurnOn();
            _fan.TurnOn();
        }

        public void TurnOffAllDevices()
        {
            _lightBulb.TurnOff();
            _fan.TurnOff();
        }
    }
}
