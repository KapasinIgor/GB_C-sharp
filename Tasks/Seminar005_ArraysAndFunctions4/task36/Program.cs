Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumOddPosOf(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = new int[4]; 

FillArray(array);
PrintArray(array);
Console.WriteLine();
int sum = SumOddPosOf(array);
Console.Write(sum); 
