// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 1. Знакомство с языком программирования С#");

Console.WriteLine("Input first number");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("-------------------Result-------------------");

if (n1>n2)
{
    Console.WriteLine($"max = {n1} , min = {n2}");
}
else
{
    if (n1<n2)
    {
        Console.WriteLine($"max = {n2} , min = {n1}");
    }
    else
        Console.WriteLine($"max = min = {n1}");
}   
Console.WriteLine("-------------------Result-------------------");