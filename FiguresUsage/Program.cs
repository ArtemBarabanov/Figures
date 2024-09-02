using Figures.Abstractions;
using Figures.Implementations;

Console.WriteLine("Пример работы с Figures");

var figures = new List<Figure>() 
{
    new Circle(3),
    new Triangle(2,2,2),
    new Triangle(2,3,4),
    new Circle(11)
};

foreach (var figure in figures) 
{
    var area = figure.CalculateArea();
    Console.WriteLine($"Площадь фигуры {figure}: равна {area}");
}

