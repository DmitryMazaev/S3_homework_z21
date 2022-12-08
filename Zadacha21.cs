/* Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты точки А:");
Console.Write("хА=");
int xA = int.Parse(Console.ReadLine()!);
Console.Write("уА=");
int yA = int.Parse(Console.ReadLine()!);
Console.Write("zА=");
int zA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки В:");
Console.Write("хВ=");
int xB = int.Parse(Console.ReadLine()!);
Console.Write("уВ=");
int yB = int.Parse(Console.ReadLine()!);
Console.Write("zВ=");
int zB = int.Parse(Console.ReadLine()!);
double l1 = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2) + Math.Pow(Math.Abs(yA - yB), 2)), 2); //Вычисление длины проекции на плоскость xy
double l2 = Math.Abs(zA - zB); //Вычисление проекции на плоскость xz
double L = Math.Round(Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2)), 2); //Вычисление расстояния между точками в 3D пространстве
Console.Write("Расстояние между точками в 3D пространстве = "+ L);