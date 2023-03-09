// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 8. Двумерные массивы. Продолжение . Задача 58");
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

int[,] TestCaseArray1()
{
    return new int[2, 2] { { 2, 4 }, { 3, 2 } };
}

int[,] TestCaseArray2()
{
    return new int[2, 2] { { 3, 4 }, { 3, 3 } };
}


int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int colsB = matrixB.GetLength(1);

    if (colsA != rowsB)
    {
        throw new ArgumentException("Matrices cannot be multiplied");
    }

    int[,] result = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}



// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

int[,] array = TestCaseArray1();
int[,] array2 = TestCaseArray2();

Console.WriteLine("Choose your destiny : 1.Fixed test case . 2(or sothing else) random array :");
int destiny = Convert.ToInt32(Console.ReadLine());
if (destiny != 1)
{
    Console.WriteLine("Input  1 <= m <= 100:");
    int m = Convert.ToInt32(Console.ReadLine());
    array = InputTwoDimensionalArray(m, m);
    array2 = InputTwoDimensionalArray(m, m);
}

int[,] matrixProduct = MatrixProduct(array, array2);


Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine("Array n1 :");
OutputArray(array);
Console.WriteLine("\n--------------------------------------------");
Console.WriteLine("Array n2 :");
OutputArray(array2);
Console.WriteLine("\n--------------------------------------------");
Console.WriteLine("Product array :");
OutputArray(matrixProduct);

Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------