// ЗАДАЧА №1218		
// Шеренга
// (Время: 1 сек. Память: 16 Мб Сложность: 18%)
// Петя впервые пришел на урок физкультуры в новой школе. Перед началом урока ученики выстраиваются по росту, в порядке невозрастания. 
//Напишите программу, которая определит на какое место в шеренге Пете нужно встать, чтобы не нарушить традицию, если заранее известен рост каждого ученика и эти данные уже расположены
// по невозрастанию (то есть каждое следующее число не больше предыдущего). Если в классе есть несколько учеников с таким же ростом, как у Пети, то программа должна расположить его
// после них.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N (N ≤ 100) – количество учеников (не считая Петю). 
//Во второй строке записаны N натуральных чисел Ai (Ai ≤ 200) – рост учеников в сантиметрах в порядке невозрастания.
// Третья строка содержит единственное натуральное число X (X ≤ 200) – рост Пети.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите единственное целое число – номер Пети в шеренге учеников.

// Пример
// №	INPUT.TXT	                                OUTPUT.TXT
// 1	8                                               3
// 165 163 160 160 157 157 155 154
// 162

int FindPetyasNumber(int[] arryOfStudentsHeights, int PetyasHight)
{
    for (int i = 0; i < arryOfStudentsHeights.Length; i++)
    {
        if (PetyasHight > arryOfStudentsHeights[i])
        {
            return i + 1;
        }
    }


    return arryOfStudentsHeights.Length + 1;
}

void SwapArrayElements(int[] array, int index1, int index2)
{
    var temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}

void SortIntArray(int[] array, bool descendent = false)
{
    for (int i = array.Length; i > 0; i--)
    {
        Boolean WasSwap = false;
        for (int j = 0; j < i - 1; j++)
        {
            if (descendent)
            {
                if (array[j] < array[j + 1])
                {
                    SwapArrayElements(array, j, j + 1);
                    WasSwap = true;
                }
            }
            else
            {
                if (array[j] > array[j + 1])
                {
                    SwapArrayElements(array, j, j + 1);
                    WasSwap = true;
                }
            }
        }

        if (!WasSwap)
        {
            break;
        }
    }
}

int[] FillArray(int n)
{
    int[] result = new int[n];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(140, 201);
    }
    SortIntArray(result, true);
    return result;
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

Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 4. Функции");

int numberOfStudents = InputCoorectNumberInRange(1, 100, "Input number of students");

int[] arryOfStudentsHeights = FillArray(numberOfStudents);

int PetyasHight = InputCoorectNumberInRange(140, 200, "Input Petya's hight (in cm) ");

Console.WriteLine("Student's hights :" + string.Join(",", arryOfStudentsHeights));
FindPetyasNumber(arryOfStudentsHeights, PetyasHight);
//



Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"Petya's order number in line is  {FindPetyasNumber(arryOfStudentsHeights, PetyasHight)}");
Console.WriteLine("\n-------------------Result-------------------");