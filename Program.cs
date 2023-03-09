// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 7. Двумерные массивы. Задача 52");
}

int[,] InputArray()
{
    Console.WriteLine("Input m :");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input n :");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10001);
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

string CalculateMidArithemetic(int[,] array)
{
    string result = string.Empty;
    double[] midValues = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            midValues[j] = midValues[j] + array[i,j];
        }
    }


    for (int i = 0; i < midValues.GetLength(0); i++)
    {
        
       midValues[i] = Convert.ToDouble( midValues[i]) / array.GetLength(0);
    }

    
    return string.Join(";",midValues);
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

int[,] array = InputArray();


Console.WriteLine("-------------------Result-------------------\n");
OutputArray(array);
Console.WriteLine(CalculateMidArithemetic(array));
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------