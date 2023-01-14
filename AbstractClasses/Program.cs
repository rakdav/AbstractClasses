using AbstractClasses;

Console.WriteLine("Введите длину:");
double width=double.Parse(Console.ReadLine());
Console.WriteLine("Введите ширину:");
double height = double.Parse(Console.ReadLine());
Rectangle rectangle=new Rectangle(width, height);
Console.WriteLine($"Площадь:{rectangle.Area():F2}, " +
    $"периметр:{rectangle.Perimeter():F2}");
Console.WriteLine("Введите радиус:");
double radius = double.Parse(Console.ReadLine());
Circle circle=new Circle(radius);
Console.WriteLine($"Площадь:{circle.Area():F2}, " +
    $"периметр:{circle.Perimeter():F2}");
Console.WriteLine("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите c:");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Введите h:");
double h = double.Parse(Console.ReadLine());
Trapezium trapezium = new Trapezium(a, b, c, h);
Console.WriteLine($"Площадь:{trapezium.Area():F2}, " +
    $"периметр:{trapezium.Perimeter():F2}");

