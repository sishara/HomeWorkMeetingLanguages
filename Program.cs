// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 5. Функции и одномерные массивы.Задача 36");
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

int[] FillIntArray(int itemNumbers, int beginRange, int endRange)
{
    int[] result = new int[itemNumbers];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(beginRange, endRange + 1);
    }

    return result;
}

int countSumOfNumbersWtihPairIndexInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            result += array[i];
        
    }
    
    return result;
};
// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
int numberOfElementsInArray = InputCoorectNumberInRange(1, 18, "Input number of items in array:");
int[] arrayOfIntNumbers = FillIntArray(numberOfElementsInArray, -10000, 10000);

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"Sum of numbers on non - pair position in [{string.Join(",", arrayOfIntNumbers)}] is  {countSumOfNumbersWtihPairIndexInArray(arrayOfIntNumbers)}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------