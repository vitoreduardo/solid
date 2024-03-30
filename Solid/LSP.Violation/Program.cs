using LSP.Violation;

Console.WriteLine("LCP Principle - Violation");

var square = new Square() 
{ 
    Height = 10, 
    Width = 5 
};

GetRectangleArea(square);

void GetRectangleArea(Rectangle rectangle)
{

    Console.WriteLine(rectangle.Area());
}