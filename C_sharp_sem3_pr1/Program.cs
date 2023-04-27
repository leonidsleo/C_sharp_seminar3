// Семинар 3. Знакомство с языками программирования. Язык C# (C_sharp).
// string f1 = "frien1";
// string f2 = "frien2";
// string f3 = "frien3";
// string f4 = "frien4";
// string f5 = "frien5";

// //string[] mass1;
// //string[] mass2 = new str[5]; 
// //string[] mass2 = new str[5] ("frien1", "frien2"); 
// //string[] mass2 = new str[5] (f1, f2); 
// string[] mass2 = {"frien2", "frien3"}; 

// Console.WriteLine($"{mass2[0]}");
// mass2[0] = "fried22"; // меняем значение в массиве
// Console.WriteLine($"{mass2[0]}");
// Console.WriteLine();
// Console.WriteLine($"{mass2.Length}"); // находим длинну массива

// foreach (string item in mass) // выводит значение, не меняет данные.
// {
//       Console.WriteLine($"foreach {item}");  
// }

// Задача №17. Напишите программу, которая принимает на вход 
//координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

// Console.Write("Введите x = ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите y = ");
// double y = Convert.ToDouble(Console.ReadLine());
// if (x == 0)
// {
//     if (y > 0)
//     {
//         Console.WriteLine("Точка находится на линии между 1 и 2 четвертью");
//     }
//     if (y < 0)
//     {
//         Console.WriteLine("Точка находится на линии между 3 и 4 четвертью");
//     }
//     if (y == 0)
//     {
//         Console.WriteLine("Точка в центре с координатами 0");
//     }
// }
// if (x > 0)
// {
//     if (y == 0)
//     {
//         Console.WriteLine("Точка находится на линии между 1 и 4 четвертью");
//     }
//     if (y > 0)
//     {
//         Console.WriteLine("Точка находится в 1-й четверти");
//     }
//     if (y < 0)
//     {
//         Console.WriteLine("Точка находится в 4-й четверти");
//     }
// }
// if (x < 0)
// {
//     if (y == 0)
//     {
//         Console.WriteLine("Точка находится на линии между 2 и 3 четвертью");
//     }
//     if (y > 0)
//     {
//         Console.WriteLine("Точка находится в 2-й четверти");
//     }
//     if (y < 0)
//     {
//         Console.WriteLine("Точка находится в 3-й четверти");
//     }
// }
// Console.Write("Stop");

// 18) Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти (от 1 до 4) = ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x == 1)
// {
//     Console.WriteLine("X = 0 до + бесконечности. Y = 0 до + бесконечности. ");
// }
// if (x == 2)
// {
//     Console.WriteLine("X = 0 до - бесконечности. Y = 0 до бесконечности. ");
// }
// if (x == 3)
// {
//     Console.WriteLine("X = 0 до - бесконечности. Y = 0 до - бесконечности. ");
// }
// if (x == 4)
// {
//     Console.WriteLine("X = 0 до бесконечности. Y = 0 до - бесконечности. ");
// }
// if (x > 4)
// {
//     Console.WriteLine($"Четверти {x} не существует. ");
// }
// if (x <= 0)
// {
//     Console.WriteLine("Такой четверти не существует ");
// }

// 21) Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
