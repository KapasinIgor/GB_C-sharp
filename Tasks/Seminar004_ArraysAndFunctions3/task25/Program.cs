Console.Clear();

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = A;

for (int i = 1; i < B; i++)
{
    result = A * result;
}

Console.Write(result);