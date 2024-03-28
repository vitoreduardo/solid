using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Violation
{
    public class Checkout
    {
        public void ProcessPayment(Payment payment, double value)
        {
            switch (payment)
            {
                case Payment.CreditCard: ProcessPaymentCreditCard(value); break;

                case Payment.PayPal: ProcessPaymentPayPal(value); break;

                case Payment.BankTransfer: ProcessPaymentBankTransfer(value); break;
            }
        }

        private void ProcessPaymentCreditCard(double value)
        {
            Console.WriteLine($"Processing credit card payment in the amount of {value}");
        }

        private void ProcessPaymentPayPal(double value)
        {
            Console.WriteLine($"Processing PayPal payment in the amount of {value}");
        }

        private void ProcessPaymentBankTransfer(double value)
        {
            Console.WriteLine($"Processing bank transfer payment in the amount of {value}");
        }
    }
}
