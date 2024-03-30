using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Solution
{
    public class Switch
    {
        private readonly List<IDevice> _devices;

        public Switch(List<IDevice> devices)
        {
                _devices = devices;
        }

        public void TurnOnAllDevices()
        {
            foreach (var device in _devices)
            {
                device.TurnOn();
            }
        }

        public void TurnOffAllDevices()
        {
            foreach (var device in _devices)
            {
                device.TurnOff();
            }
        }
    }
}
