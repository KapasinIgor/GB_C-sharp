Console.Clear();

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
}

void PrintMatrixMulti(int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j] + " ");
        }
        Console.Write("| ");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintMatrixResult(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    Console.WriteLine();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }


}

Console.WriteLine("Дана две матрицы: ");
int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] matrix3 = new int[2, 2];
CreateMatrix(matrix1);
CreateMatrix(matrix2);
PrintMatrixMulti(matrix1, matrix2);
MatrixMultiplication(matrix1, matrix2, matrix3);
Console.WriteLine("Ниже результат перемножения этих матриц: ");
PrintMatrixResult(matrix3);

//процедура PrintMatrixMulti для красоты, что бы выводилось как в условии с черточками. По хорошему все выводы можно через единую процедуру  PrintMatrix сделать.