Console.Clear();

int SumElements(int M, int N)
{
    if (M == N) return M;
    return SumElements(M, N - 1) + N;
}

Console.Write("Введите начальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма чисел от {M} до {N} равна {SumElements(M, N)}");