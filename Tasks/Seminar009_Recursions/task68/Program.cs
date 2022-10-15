Console.Clear();

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.Write("Введите начальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Вычисление по функции Аккермана - {Ackerman(m, n)}");
