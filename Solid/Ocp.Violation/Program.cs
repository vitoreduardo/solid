using Ocp.Violation;

Console.WriteLine("OCP Principle - Violation");

var checkout = new Checkout();

checkout.ProcessPayment(Payment.CreditCard, 100);
checkout.ProcessPayment(Payment.PayPal, 345);
checkout.ProcessPayment(Payment.BankTransfer, 345.65);