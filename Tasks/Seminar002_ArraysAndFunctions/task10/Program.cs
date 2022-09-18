Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int middle = number / 10 % 10;

Console.WriteLine($"Средняя цифра - {middle}");