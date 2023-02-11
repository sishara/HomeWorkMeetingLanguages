// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 5. Функции и одномерные массивы.Задача 34");
}

int InputCoorectNumberInRange(int beginRange, int endRange, string Message)
{
    int numberInRange = 0;
    string buildedMessage = $"Intput {Message} in range ({beginRange} < N <= {endRange}):";
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

int[] FillIntArray(int itemNumbers, int beginRange, int endRange)
{
    int[] result = new int[itemNumbers];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(beginRange, endRange + 1);
    }

    return result;
}

int countPairNumbersInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] % 2 == 0)
            result++;
        if (array[array.Length - i - 1] % 2 == 0)
            result++;
    }
    if (array.Length % 2 == 1 && array[array.Length / 2 + 1] % 2 == 0)
        result++;
    return result;
};
// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
int numberOfElementsInArray = InputCoorectNumberInRange(1, 18, "Input number of items in array:");
int[] arrayOfIntNumbers = FillIntArray(numberOfElementsInArray, 100, 999);

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"Count of pair numbers in [{string.Join(",", arrayOfIntNumbers)}] is  {countPairNumbersInArray(arrayOfIntNumbers)}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------