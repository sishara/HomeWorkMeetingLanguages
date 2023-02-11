// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать Math.Pow();
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int MyPow(int x, int y)
{
    if (y == 0)
    {
        return 1;
    }
    
    int result = x;
    for (int i = 1; i < y; i++)
    {
        result = result * x;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 4. Функции");
Console.Write("Intput number A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Intput number B (the pow of A):");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"{a} at power {b} = {MyPow(a, b)}");
Console.WriteLine("\n-------------------Result-------------------");