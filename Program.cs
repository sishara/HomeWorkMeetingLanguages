// Урок 3. Базовые алгоритмы. Продолжение

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 3. Базовые алгоритмы. Продолжение");

int number = 0;
string stringNumber = "";
string result = "No";
while (number / 10000 < 1 || number / 10000 > 10)
{
    Console.WriteLine("Input 5 length digits number:");
    stringNumber = Console.ReadLine();
    try
    {
        number = Convert.ToInt32(stringNumber);
    }
    catch (System.Exception)
    {
        Console.WriteLine("Wrong input !");
    }

};

if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    result = "Yes";
};
Console.WriteLine("-------------------Result-------------------");
Console.WriteLine(result);
Console.WriteLine("-------------------Result-------------------");