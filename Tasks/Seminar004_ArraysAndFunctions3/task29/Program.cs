Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} число массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
    }
}

void PrintArray(int[] array)
{
    int position = 0;
    Console.Write("[");
    while (position < array.Length)
    {
        if (position + 1 == array.Length) Console.Write($"{array[position]}");
        else Console.Write($"{array[position]}, ");
        position++;
    }
    Console.Write("]");
}

int[] array = new int[8]; 

FillArray(array);
PrintArray(array);