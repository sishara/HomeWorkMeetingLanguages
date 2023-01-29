// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 2. Базовые алгоритмы , С#");

Console.WriteLine("Input number in range 1-7:");
int n = Convert.ToInt32(Console.ReadLine());

string Result = "No";
if ((n == 6 || n == 7))
{
    Result = "Yes";
}
Console.WriteLine("-------------------Result-------------------");
//Console.WriteLine((n == 6 || n == 7));
Console.WriteLine(Result);
Console.WriteLine("-------------------Result-------------------");