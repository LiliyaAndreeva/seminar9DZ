// Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в 
//  промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m=int.Parse(ReadLine());

Write("Введите N: ");
int n=int.Parse(ReadLine());

WriteLine($"Сумма чисел от {m} до {n} = {PrintSum(m,n)}");

int PrintSum(int start, int end)
{
//   {
//     if (end < start) return 0;
//     Console.WriteLine(end);
//     int s = (end + PrintSum(start, end-1));
//     return s;
//     Console.WriteLine(s);
// }
if (start==end) return start;
Console.WriteLine(start);
int s =  (start + PrintSum(start+1, end));
return s;
Console.WriteLine(s);
}