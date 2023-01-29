//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 1. Знакомство с языком программирования С#");

Console.WriteLine("Input first number");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if (n2 > n1)
{
    max = n2;
 
}
if (n3> max)
{
    max = n3;
}

Console.WriteLine("-------------------Result-------------------");
Console.WriteLine(max);
Console.WriteLine("-------------------Result-------------------");