// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 7. Двумерные массивы. Задача 47");
}

double[,] InputArray()
{
    Console.WriteLine("Input m :");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input n :");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * random.Next(-10000, 10001),1);
        }
    }

    return array;
}

void OutputArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

double[,] array = InputArray();


Console.WriteLine("-------------------Result-------------------\n");
OutputArray(array);
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------