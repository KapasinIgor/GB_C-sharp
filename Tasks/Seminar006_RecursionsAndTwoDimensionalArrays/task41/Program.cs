Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int ZeroOf(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    return sum;
}

Console.Write("Введите количество чисел в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count]; 

FillArray(array);
PrintArray(array);
Console.WriteLine();
int sum = ZeroOf(array);
Console.Write(sum); 

