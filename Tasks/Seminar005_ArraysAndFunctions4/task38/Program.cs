Console.Clear();

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100)/10.0;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double DiffMinMaxOf(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return Math.Round(max - min, 2);
}


double[] array = new double[4]; 

FillArray(array);
PrintArray(array);
Console.WriteLine();
double diff = DiffMinMaxOf(array);
Console.Write(diff); 

