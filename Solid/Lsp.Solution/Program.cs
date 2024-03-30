using Lsp.Solution;

Console.WriteLine("LCP Principle - Solution");

var square = new Square()
{
    Side = 5
};

GetShapeArea(square);

void GetShapeArea(Shape rectangle)
{

    Console.WriteLine(rectangle.Area());
}