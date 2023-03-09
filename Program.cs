//ЗАДАЧА №1236
// Транспонирование - 4
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.

// Пример
// №	INPUT.TXT	OUTPUT.TXT
// 1	3 4
// 5 9 2 6
// 6 2 4 3
// 1 2 8 7	1 2 8 7
// 6 2 4 3
// 5 9 2 6



void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 7. Двумерные массивы. Доп задача №1236");
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
            array[i, j] = random.Next(0, 101);
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

void TrnasponateVsHorizont(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - i-1, j];
            array[array.GetLength(0) - i-1, j] = temp;

        }
    }

}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

int[,] array = InputArray();


Console.WriteLine("-------------------Result-------------------\n");
OutputArray(array);
TrnasponateVsHorizont(array);
Console.WriteLine("\n--------------------------------------------");
OutputArray(array);
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------