using Isp.Violation;

Console.WriteLine("ISP Principle - Violation");

IDocumentProcessor document = new GenericDocument();
document.Print();
document.Scan();

IDocumentProcessor newspaper = new Newspaper();
newspaper.Print();
newspaper.Scan();