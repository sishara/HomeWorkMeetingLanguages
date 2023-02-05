// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 3. Базовые алгоритмы. Продолжение");

Console.WriteLine("Input number N :");
int n = 0;
while (n == 0)
{
    try
    {
        n = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.Exception)
    {
        Console.WriteLine("Input correct number N :");
    }

};

Console.WriteLine("-------------------Result-------------------");
for (int i = 1; i <= n; i++)
{
    Console.Write(i * i * i + ", ");
};
Console.WriteLine("\n-------------------Result-------------------");