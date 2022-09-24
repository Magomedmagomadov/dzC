/*  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/


Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("no " + n % 2);
 