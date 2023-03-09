//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 8. Двумерные массивы. Продолжение . Задача 61");
}

void PascalTriangles()
{
    Console.Write("Input rows number: ");
    int n = int.Parse(Console.ReadLine());

    int[,] pascal = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
            {
                pascal[i, j] = 1;
            }
            else
            {
                pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
            }
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int k = 0; k < n - i; k++)
        {
            Console.Write("  ");
        }

        for (int j = 0; j <= i; j++)
        {
            Console.Write("{0,4}", pascal[i, j]);
        }

        Console.WriteLine();
    }
}





// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
Console.WriteLine("-------------------Result-------------------\n");
PascalTriangles();
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------