
using Ocp.Solution;

Console.WriteLine("OCP Principle - Solution");

var checkout = new Checkout(new CreditCard());
checkout.ProcessPayment(100);

checkout.ProcessPayment(134.67);

checkout = new Checkout(new PayPal());
checkout.ProcessPayment(543.34);
