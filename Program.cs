 // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 2. Базовые алгоритмы , С#");

Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
string result = "третьей цифры нет";
if (n >=100)
{
    while(n >1000)
    {
        n = n / 10;
    }
    result = Convert.ToString(n % 10);
}



Console.WriteLine("-------------------Result-------------------");
Console.WriteLine(result);
Console.WriteLine("-------------------Result-------------------");