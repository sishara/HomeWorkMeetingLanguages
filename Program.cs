// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 8. Двумерные массивы. Продолжение . Задача 56");
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

int GetLineWithLowestSum(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    int lowestSumIndex = 0;
    int lowestSum = int.MaxValue;

    for (int i = 0; i < rowCount; i++)
    {
        int sum = 0;
        for (int j = 0; j < colCount; j++)
        {
            sum += array[i, j];
        }

        
        if (sum < lowestSum)
        {
            lowestSum = sum;
            lowestSumIndex = i;
        }
    }

    return lowestSumIndex +1;
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
Console.WriteLine($"The line with the lowest sum is {GetLineWithLowestSum(array)}");

Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------