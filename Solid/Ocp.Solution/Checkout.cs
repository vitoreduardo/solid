using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Solution
{
    public class Checkout
    {
        private readonly IProcessPayment _processPayment;

        public Checkout(IProcessPayment processPayment)
        {
            _processPayment = processPayment;
        }

        public void ProcessPayment(double value)
        {
            _processPayment.ProcessPayment(value);
        }
    }
}
