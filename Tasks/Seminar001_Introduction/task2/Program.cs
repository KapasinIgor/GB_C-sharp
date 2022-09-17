//Задача 2
Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a < b)
{
    max = b;
    min = a;
}

Console.WriteLine($"Максимальное число -  {max}");
Console.WriteLine($"Минимальное число -  {min}");