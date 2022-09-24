Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n1 = number % 10;
int n2 = (number / 10) % 10;
int n3 = (number / 100) % 10;
int n4 = (number / 1000) % 10;
int n5 = number / 10000;

if (n1 == n5 && n2 == n4) Console.Write("Число палиндром!");
else Console.Write("Обычное число");