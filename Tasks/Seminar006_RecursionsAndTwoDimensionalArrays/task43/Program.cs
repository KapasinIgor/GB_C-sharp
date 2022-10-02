Console.Clear();

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.Write("Прямые равны друг другу - бесконечно много точек");
else if (k1 == k2) Console.Write("Прямые параллельны - никогда не пересекутся");
else 
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.Write($"({x};{y})");
}
