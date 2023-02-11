// Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 5. Функции и одномерные массивы.Задача 38");
}

int InputCoorectNumberInRange(int beginRange, int endRange, string Message)
{
    int numberInRange = 0;
    string buildedMessage = $"Intput {Message} in range ({beginRange} <= N <= {endRange}):";
    Console.Write(buildedMessage);

    while (numberInRange < beginRange || numberInRange > endRange)
    {
        try
        {
            numberInRange = Convert.ToInt32(Console.ReadLine());
            if (numberInRange < beginRange || numberInRange > endRange)
            {
                Console.WriteLine($"Incorrect input ." + buildedMessage);
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine($"Incorrect input ." + buildedMessage);
            numberInRange = 0;
            ;
        }

    };
    return numberInRange;
}

double[] FillDoubleArray(int itemNumbers, int beginRange, int endRange)
{
    double[] result = new double[itemNumbers];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(beginRange, endRange + 1) + Convert.ToDouble(new Random().Next(0, 100)) / 100;
    }

    return result;
}

double FindDiffMaxMin(double[] array)
{
    double Max = 0,
          Min = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (Max < array[i])
            Max = array[i];
        if (Min > array[i])
            Min = array[i];
    }
    return Max - Min;
};
// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
int numberOfElementsInArray = InputCoorectNumberInRange(1, 100, "Input number of items in array:");
double[] arrayOfdoubleNumbers = FillDoubleArray(numberOfElementsInArray, -10000, 10000);
double diffMaxMin = FindDiffMaxMin(arrayOfdoubleNumbers);

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"[{string.Join(" ",arrayOfdoubleNumbers)}]");
Console.WriteLine($"Diffrence Max - Min = {diffMaxMin}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------