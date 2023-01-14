using AbstractClasses;

Console.WriteLine("Введите длину:");
double width=double.Parse(Console.ReadLine());
Console.WriteLine("Введите ширину:");
double height = double.Parse(Console.ReadLine());
Rectangle rectangle=new Rectangle(width, height);
Console.WriteLine($"Площадь:{rectangle.Area():F2}, " +
    $"периметр:{rectangle.Perimeter():F2}");