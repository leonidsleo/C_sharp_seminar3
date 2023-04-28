// Семинар 3. Домашнее задание. Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Палиндром или нет число из пяти знаков?");
// Console.WriteLine();
// Console.Write("Введите пятизначное число n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int L = (int)Math.Log10(n)+1;
// //Console.WriteLine(L);
// if (L != 5)
// {
//     Console.WriteLine($"Число {n} не является пятизначным. Повторите ввод!");
// }
// else
// {
//     int a5 = n % 10;
//     n = n / 10;
//     int a4 = n % 10;
//     n = n / 10;
//     int a3 = n % 10;
//     n = n / 10;
//     int a2 = n % 10;
//     n = n / 10;
//     int a1 = n % 10;
//     if (a1 == a5 || a2 == a4)
//     {
//         Console.WriteLine("Число n является палиндромом!");
//     }
//     else
//     {
//         Console.WriteLine("Число n не является палиндромом!");
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Стоп");

Console.WriteLine("Палиндром или нет число из пяти знаков?");
Console.WriteLine();
Console.Write("Введите пятизначное число n = ");
short n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();
short L = Convert.ToInt16((int)Math.Log10(n)+1);
//Console.WriteLine(L);
if (L != 5)
{
    Console.WriteLine($"Число {n} не является пятизначным. Повторите ввод!");
}
else
{
    short a5 = Convert.ToInt16(n % 10);
    n = Convert.ToInt16(n / 10);
    short a4 = Convert.ToInt16(n % 10);
    n = Convert.ToInt16(n / 10);
    short a3 = Convert.ToInt16(n % 10);
    n = Convert.ToInt16(n / 10);
    short a2 = Convert.ToInt16(n % 10);
    n = Convert.ToInt16(n / 10);
    short a1 = Convert.ToInt16(n % 10);
    if (a1 == a5 || a2 == a4)
    {
        Console.WriteLine("Число n является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число n не является палиндромом!");
    }
}
Console.WriteLine();
Console.WriteLine("Стоп");