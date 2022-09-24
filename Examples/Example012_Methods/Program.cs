// //Вид1 - ничего не возвращают и ничего не принимают
// void Method1()
// {
//     Console.WriteLine("Вид1");
// }

// Method1();


// //Вид2 - принимают аргументы и ничего не возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Вид2");
// //Method2(msg: "Вид2"); // если несколько переменных


// //Вид3 - возвращают и ничего не принимают
// int Method3();
// {
//     return delegateTime.Now.Year;
// }

// int year = Method3();
// Console.Write(year);


// //Вид4 - возвращают и принимают
// int Method4(int count, string text);
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result += text;
//     }
//     return result;
// }

// string res = Method4(10, "text");
// Console.Write(res);

for (int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}