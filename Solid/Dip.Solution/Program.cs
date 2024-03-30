
using Dip.Solution;

Console.WriteLine("ISP Principle - Solution");

var devices = new List<IDevice> 
{
    new Fan(),
    new LightBulb()
};


var smartSwitch = new Switch(devices);
smartSwitch.TurnOnAllDevices();
smartSwitch.TurnOffAllDevices();