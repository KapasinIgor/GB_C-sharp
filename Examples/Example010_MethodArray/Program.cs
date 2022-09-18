Console.Clear();

int[] array = {12, 4, 45, 56, 25, 26, 36, 7, 16};

int index = 0;
int find = 4;

while (index < array.Length)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

