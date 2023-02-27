// Напишите программу вычисления 
// функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());

Write("Введите M: ");
int m=int.Parse(ReadLine());

WriteLine(FuncAcc(m,n));

int FuncAcc(int n,int m)
{
  if (n==0) return m+1;
  else if (m==0 && n>0) return FuncAcc(n-1,1);
  else return FuncAcc(n-1,FuncAcc(n,m-1));
}