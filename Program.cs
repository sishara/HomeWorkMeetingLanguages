// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 9. Рекурсия. Задача 68");
}

int Ackerman(int x, int y)
{
    if (x == 0) return y + 1;
    if (y == 0) return Ackerman(x - 1, 1);
    return Ackerman(x - 1, Ackerman(x, y - 1));
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
Console.WriteLine("Input M :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input N :");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("-------------------Result-------------------\n");
Console.Write(Ackerman(m, n));
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------