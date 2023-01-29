// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 2. Базовые алгоритмы , С#");

Console.WriteLine("Input number in range 100-999 :");
int n = Convert.ToInt32(Console.ReadLine());


if (n < 100 || n > 999 )
{
    Console.WriteLine("Wrong number");
    return;
}
int result = n / 10;
result = result % 10;


Console.WriteLine("-------------------Result-------------------");
Console.WriteLine(result);
Console.WriteLine("-------------------Result-------------------");