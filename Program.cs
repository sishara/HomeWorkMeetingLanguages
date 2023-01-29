// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 1. Знакомство с языком программирования С#");

Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());

string result = "Yes";


if ( n % 2 != 0)
{
    result = "No";
 
}


Console.WriteLine("-------------------Result-------------------");
Console.WriteLine(result);
Console.WriteLine("-------------------Result-------------------");