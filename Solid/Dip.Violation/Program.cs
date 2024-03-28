using Dip.Violation;

Console.WriteLine("ISP Principle - Violation");

Switch smartSwitch = new Switch();
smartSwitch.TurnOnAllDevices();
smartSwitch.TurnOffAllDevices();