// Семинар 3. Домашнее задание. Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Найти расстояние между 2-мя точками по координатам в 3D пространстве!");
Console.WriteLine();
Console.Write("Введите x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Координаты точки А = ({x1}; {y1}; {z1});");
Console.WriteLine($"Координаты точки В = ({x2}; {y2}; {z2});");
Console.WriteLine();
double a = (Math.Pow((x2 - x1), 2)) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
double b = Math.Sqrt(a);
b = Math.Round(b, 2);
Console.WriteLine($"Раcстояние между точками = {b}!");
Console.Write("Stop");