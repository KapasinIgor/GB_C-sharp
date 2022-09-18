Console.Clear();

Console.Write("Введите цифру дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum == 6 || dayNum == 7 && dayNum < 8) Console.WriteLine("Выходной день!)");
else if (dayNum > 7) Console.WriteLine("В неделе 7 дней, попробуйте заново");
else Console.WriteLine("Будний день...");