// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int CountDigitInNumber(int Number)
{
    int result = 0;
    string strNumber = Convert.ToString(Number);
    foreach (char item in strNumber)
    {
        result = result + Convert.ToInt32(item.ToString());
    };
    return result;
}

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 4. Функции");
Console.Write("Intput number :");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"The sum of digits in number {a} is  {CountDigitInNumber(a)}");
Console.WriteLine("\n-------------------Result-------------------");