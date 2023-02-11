// ЗАДАЧА №1220		
// Суперсдвиг
// (Время: 1 сек. Память: 16 Мб Сложность: 20%)
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, 
//если отрицательное.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

// Выходные данные
// В выходной файл OUTPUT.TXT выведите полученную последовательность.

// Примеры
// №	INPUT.TXT	OUTPUT.TXT
//5
// 5 3 7 4 6        7 4 6 5 3
// 3	

//5
//5 3 7 4 6        4 6 5 3 7
//-3	

void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 4. Функции . Доп ЗАДАЧА №1220 . Суперсдвиг");
}

int InputCoorectNumberInRange(int beginRange, int endRange, string Message)
{
    int numberInRange = beginRange - 1;
    string buildedMessage = $"Intput {Message} in range ({beginRange} < N <= {endRange}):";
    Console.WriteLine(buildedMessage);

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

int[] MoveElementsInArray(int[] array, int move)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int newIndex = i + move;
        
        if (newIndex < 0)
        {
            newIndex =  array.Length + newIndex;
        }else
        {
            int dif = newIndex - (array.Length-1);
            if (dif >0)
            {
                newIndex =  dif -1;
            }
        }
        
        result[newIndex] = array[i];
    }
    return result;
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
int beginRange = 1, endRange = 105;

int numberOfElementsInArray = InputCoorectNumberInRange(beginRange, endRange, "number of elements in array");
int[] array = FillIntArray(numberOfElementsInArray, 1, 100);
int move = InputCoorectNumberInRange(-numberOfElementsInArray, numberOfElementsInArray, " number > 0 to move right , or number < 0 to move left ");
int[] processedArray = MoveElementsInArray(array, move);

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"Initial   array  [{string.Join(",", array)}] ");
Console.WriteLine($"Processed array  [{string.Join(",", processedArray)}] ");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------