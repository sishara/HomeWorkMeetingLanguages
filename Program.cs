// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 9. Рекурсия. Задача 66");
}

int SumOfNaturalNumbersBetween(int M, int N)
{
    if (M < N)
        return M + SumOfNaturalNumbersBetween(M + 1, N);
    return M;
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
Console.WriteLine("Input M :");
int startInterval = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input N > {startInterval}:");
int endInterval = Convert.ToInt32(Console.ReadLine());

while (endInterval <= startInterval)
{
    Console.WriteLine($"Input N > {startInterval}:");
    endInterval = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("-------------------Result-------------------\n");
Console.Write(SumOfNaturalNumbersBetween(startInterval, endInterval));
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------