Console.Clear();

Console.Write("Введите любое число: ");
string number = Convert.ToString(Console.ReadLine());

if (number.Length < 3) Console.WriteLine("В данном числе третьей цифры нет!");
else Console.WriteLine(number[2]);