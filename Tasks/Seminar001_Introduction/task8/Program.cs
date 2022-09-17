//Задача 8
Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string result = "";

for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0) result += $"{i}, ";
}

Console.Write(result.Substring(0, (result.Length - 2)));

