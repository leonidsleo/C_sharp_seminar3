// Семинар 3. Домашнее задание. Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Найти кубы всех чисел от числа a до числа n!");
Console.WriteLine();
Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
//int c = a;

if (a > n)
{
    Console.WriteLine("Число a должно быть меньше n");
}
if (a < n)
{
    Console.Write("Кубы всех чисел от a до n = ");
    while (a <= n)
    {
        int c = a;
        c = Convert.ToInt32(Math.Pow(c, 3));
        a = a + 1; 
        Console.Write(c + ", ");
    }
}
Console.WriteLine();
Console.Write("Stop");