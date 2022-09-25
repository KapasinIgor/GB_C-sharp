Console.Clear();

Console.Write("Введите число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = 0;

while (n > 0)
{
    result += n % 10;
    n = n / 10;
}

Console.Write(result);