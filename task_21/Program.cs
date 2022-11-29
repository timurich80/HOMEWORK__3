/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


Console.Clear();

System.Console.WriteLine("Введите координату ax: ");
int ax = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату ay: ");
int ay = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату az: ");
int az = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату bx: ");
int bx = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату by: ");
int by = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату bz: ");
int bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bx-ax),2) + 
Math.Pow((by-ay),2) + Math.Pow((bz-az),2));
System.Console.WriteLine(Math.Round(result, 2));