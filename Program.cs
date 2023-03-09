// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такой позиции в массиве нет
// 1 2 -> На данной позиции находиться элемент 4


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 7. Двумерные массивы. Задача 50");
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

string FindPosition(int[,] array)
{
    Console.WriteLine("Input coordinates m , n in bidimensional array :");
    int[] inputCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (inputCoord[0] > array.GetLength(0)||inputCoord[1] > array.GetLength(1))
    {
        return "This position in array don't exist";
    }
    return $"Value at this position is {array[inputCoord[0]-1,inputCoord[1]-1]}";
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

int[,] array = InputArray();


Console.WriteLine("-------------------Result-------------------\n");
OutputArray(array);
Console.WriteLine(FindPosition(array));
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------