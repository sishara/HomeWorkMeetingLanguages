// ЗАДАЧА №5		
// Статистика
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность:
//  по нечетным дням месяца он получал тройки, а по четным – четверки. Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, 
// чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. 
// Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

// Входные данные
// В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100). 
// Вторая строка содержит N чисел, представляющих заданный массив. Каждый элемент массива – натуральное число от 1 до 31. Все элементы массива разделены пробелом.

// Выходные данные
// В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые Вася получил тройки, а во второй строке соответственно расположить 
// числа месяца, в которые Вася получил четверки. В третьей строке нужно вывести «YES», если Вася может рассчитывать на четверку и «NO» в противном случае. В каждой строчке числа 
// следует выводить в том же порядке, в котором они идут во входных данных. При выводе числа отделяются пробелом.

// Примеры
// INPUT.TXT	            OUTPUT.TXT
// 5
// 4 16 19 31 2	            19 31
//                          4 16 2
//                          YES
// 8
// 29 4 7 12 15 17 24 1 	29 7 15 17 1
//                          4 12 24
//                          NO




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 5. Функции и одномерные массивы. Доп ЗАДАЧА №5 ");
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

ArraySegment<int> FiltreIntArrayByIndexPairUnpair(int[] array, int pair)
{
    int[] result = new int[array.Length];

    int intResultLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (pair == 1 && array[i] % 2 == 0)
        {
            result[intResultLength] = array[i];
            intResultLength++;
        }
        else
            if (pair == 0 && array[i] % 2 == 1)
        {
            result[intResultLength] = array[i];
            intResultLength++;
        }

    }
    ArraySegment<int> Finalresult = new ArraySegment<int>(result,0,intResultLength);
    return Finalresult;
};

string isVaseaOk(ArraySegment<int> filtredArrayOfIntNumbersNonPair, ArraySegment<int> filtredArrayOfIntNumbersPair)
{
    if(filtredArrayOfIntNumbersPair.Count >= filtredArrayOfIntNumbersNonPair.Count)
        return "Yes";
    return "No";
}


// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
int numberOfElementsInArray = InputCoorectNumberInRange(1, 100, "Input number of items in array:");
int[] arrayOfIntNumbers = FillIntArray(numberOfElementsInArray, 1, 31);
ArraySegment<int> filtredArrayOfIntNumbersNonPair = FiltreIntArrayByIndexPairUnpair(arrayOfIntNumbers, 0);
ArraySegment<int> filtredArrayOfIntNumbersPair = FiltreIntArrayByIndexPairUnpair(arrayOfIntNumbers, 1);

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"[{string.Join(" ", filtredArrayOfIntNumbersNonPair)}]");
Console.WriteLine($"[{string.Join(" ", filtredArrayOfIntNumbersPair)}]");
Console.WriteLine($"{isVaseaOk(filtredArrayOfIntNumbersNonPair, filtredArrayOfIntNumbersPair)}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------