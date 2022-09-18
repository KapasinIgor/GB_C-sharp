Console.Clear();

void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collect)
{
    int position = 0;
    while (position < collect.Length)
    {
        Console.Write($"{collect[position]} ");
        position++;
    }
}

int FindIndexOf(int[] collection, int find)
{
    int index = 0;
    int posit = -1;
    while (index < collection.Length)
    {
        if (collection[index] == find)
        {
            posit = index;
        }
        index++;
    }
    return posit;
}

int[] array = new int[10]; 

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = FindIndexOf(array, 4);
if (pos == -1) Console.WriteLine("элемент отсутствует");
else Console.WriteLine(pos);
