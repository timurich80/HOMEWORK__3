/* Задача 23
Напишите программу, которая принимает на вход 2 числа (N,M) 
 и выдаёт таблицу кубов чисел от N до M.
2,3 -> 8, 27
1,5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
double  cub = 0;
System.Console.Write($"{n}, {m} -> ");

for (int count = n; count <= m; count++)
{
    cub = Math.Pow(count,3);
    Console.Write($"{cub}, ");
    ;
}