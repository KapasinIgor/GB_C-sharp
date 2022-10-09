Console.Clear();

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
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
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void SearchAndPrintElement(int[,] matrix, int x, int y)
{
    Console.WriteLine();
    if (matrix.GetLength(0) < x || matrix.GetLength(1) < y) Console.Write("Такой строки и(или) столбца нет!");
    else Console.Write(matrix[x - 1, y - 1]);
}

Console.WriteLine("Дана матрица вида: ");

int[,] matrix = new int[3, 4];

CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

SearchAndPrintElement(matrix, x, y);