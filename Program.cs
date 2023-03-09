// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2





void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 8. Двумерные массивы. Продолжение . Задача 54");
}

int[,] InputTwoDimensionalArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }

    return array;
}

void OutputArray(int[,] array)
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

void SortRowsDescending(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        int[] row = new int[colCount];
        for (int j = 0; j < colCount; j++)
        {
            row[j] = array[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int j = 0; j < colCount; j++)
        {
            array[i, j] = row[j];
        }
    }
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

Console.WriteLine("Input  1 <= m <= 100:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input  1 <= m <= 100:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = InputTwoDimensionalArray(m, n);


Console.WriteLine("-------------------Result-------------------\n");
OutputArray(array);
Console.WriteLine("\n--------------------------------------------");
SortRowsDescending(array);
OutputArray(array);
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------