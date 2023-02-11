//  ЗАДАЧА №323
// Гипотеза Гольдбаха
// (Время: 1 сек. Память: 16 Мб Сложность: 30%)
// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько.
//  Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.

// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа. Из всех пар простых чисел, 
// сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.

// Входные данные
// Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).

// Выходные данные
// В выходной файл OUTPUT.TXT необходимо вывести два простых числа, сумма которых равна числу N. Первым выводится наименьшее число.

// Примеры
// №	INPUT.TXT	OUTPUT.TXT
// 1	6	            3 3
// 2	992	            73 919


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 4. Функции . Доп ЗАДАЧА №323 . Гипотеза Гольдбаха");
}

int InputCoorectPairNumberGreaterThenTwo()
{
    int pairNumber = 3;
    string buildedMessage = $"Intput pair number greater than 2:";
    Console.WriteLine(buildedMessage);

    while (pairNumber <= 2 || pairNumber % 2 == 1)
    {
        try
        {
            pairNumber = Convert.ToInt32(Console.ReadLine());
            if (pairNumber <= 2 || pairNumber % 2 == 1)
            {
                Console.WriteLine($"Incorrect input ." + buildedMessage);
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine($"Incorrect input ." + buildedMessage);
            pairNumber = 3;
            ;
        }

    };
    return pairNumber;
}

bool NumberIsPrime(int number)
{
    int divisor = 2,
        divisionCount = 0;

    while (number > 1)
    {
        while (number % divisor == 0)
        {
            divisionCount++;
            if (divisionCount > 1)
                return false;
            number /= divisor;
        }

        if (divisionCount > 1)
            return false;

        divisor++;


        if (number > 1 && divisor * divisor > number)
        {
            divisor = number;
        }
    }

    return divisionCount <= 1;
}

string FindGoldbachsConjecture(int pairNumber)
{
    string Result = pairNumber.ToString();

    for (int i = 3; i < pairNumber; i += 2)
    {
        int difResult = pairNumber - i;
        
        if (!NumberIsPrime(i))
            continue;
       
        if (!NumberIsPrime(difResult))
            continue;

        return "" + i + " " + difResult;

    }

    return "Algorithm got errors or input data are bad";
}


// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
int pairNumber = InputCoorectPairNumberGreaterThenTwo();
string GoldbachsConjecture = FindGoldbachsConjecture(pairNumber);

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"Goldbach's conjecture  for number {pairNumber} is  {GoldbachsConjecture}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------