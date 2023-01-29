// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 1. Знакомство с языком программирования С#");

Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
string result = "";
if (n < 1)
{
    return;
}

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        result = result + i + ",";
    }
}


Console.WriteLine("-------------------Result-------------------");
Console.WriteLine(result);
Console.WriteLine("-------------------Result-------------------");