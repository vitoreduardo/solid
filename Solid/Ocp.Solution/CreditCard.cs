using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Solution
{
    public class CreditCard : IProcessPayment
    {
        public void ProcessPayment(double value)
        {
            Console.WriteLine($"Processing credit card payment in the amount of {value}");
        }
    }
}
