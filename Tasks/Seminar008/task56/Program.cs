Console.Clear();

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void MinSumLineMatrix(int[,] matrix)
{
    Console.WriteLine();
    int minRow = 0;
    int? minSum = null;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (minSum is null) minSum = sumRow;
        if (sumRow < minSum)
        {
            minRow = i + 1;
            minSum = sumRow;
        } 
    }
    Console.WriteLine($"Минимальная сумма в строке №{minRow}");
}

Console.WriteLine("Дана матрица вида: ");
int[,] matrix = new int[4, 4];
CreateMatrix(matrix);
PrintMatrix(matrix);
MinSumLineMatrix(matrix);
