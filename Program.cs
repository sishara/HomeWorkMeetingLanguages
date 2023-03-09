// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 8. Двумерные массивы. Продолжение . Задача 60");
}

int[,,] GetThreeDimensionalArray(int x, int y, int z)
{
    int iterator = 10;
    int[,,] array = new int[x, y, z];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = iterator;
                iterator++;
            }
        }
    }

    return array;
}

void OutputArray(int[,,] array)
//  в примере задачи как то странно выводит ... будь-то последовательность итереторва  1 и 2 перепутанны - тоесть  цикл бегает по одному измерению но выводит их в 
// разной последовательности - уж не знаю это просто так получилось или с какой-то целью .
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
             Console.WriteLine();
        }
       
    }
}


// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

int[,,] array = GetThreeDimensionalArray(2, 2, 2);

Console.WriteLine("-------------------Result-------------------\n");
OutputArray(array);

Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------