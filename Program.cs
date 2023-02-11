// ЗАДАЧА №496		
// Сбор черники
// (Время: 1 сек. Память: 16 Мб Сложность: 17%)
// В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены только по окружности. 
//Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.

// Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте выросло ai ягод.

// В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля и нескольких собирающих модулей. 
//Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.

// Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники.
// Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.

// №	INPUT.TXT	OUTPUT.TXT
// 4
// 1 2 3 4	            9

// 3
// 1 2 3	            6


Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 3. Базовые алгоритмы. Продолжение");

Console.WriteLine("Input number of blueberry bush (3 ≤ N ≤ 1000) :");
int numberOfBush = 0;
while (numberOfBush < 3 || numberOfBush > 1000)
{
    try
    {
        numberOfBush = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.Exception)
    {

        Console.WriteLine("Input correct number of blueberry bush (3 ≤ N ≤ 1000) :");
    }
};

Console.WriteLine($"Input using (, as delimeter ) {numberOfBush} numbers(3 ≤ N ≤ 1000)  of blueberry fruits for each bush  :");
string[] arrayOfBlueberryFruitsOnEachBush = Convert.ToString(Console.ReadLine()).Split(",");

int maxResult = 0;
int intLength = arrayOfBlueberryFruitsOnEachBush.Length;
int intCurrentResult = 0;
for (int i = 0; i < arrayOfBlueberryFruitsOnEachBush.Length -2; i++)
{   
    intCurrentResult = Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[i]) +
                          Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[i+1]) +
                          Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[i+2]);
    if (intCurrentResult > maxResult)
    {
        maxResult = intCurrentResult;
    }

}

intCurrentResult = Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[0]) + Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[intLength-2]) +
                   Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[intLength-1]);
if ( intCurrentResult > maxResult )
    maxResult = intCurrentResult;
intCurrentResult = Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[0]) + Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[1]) +
                   Convert.ToInt32(arrayOfBlueberryFruitsOnEachBush[intLength-1]);
if ( intCurrentResult > maxResult )
    maxResult = intCurrentResult;

Console.WriteLine("-------------------Result-------------------");
Console.WriteLine($"{maxResult}");
Console.WriteLine("\n-------------------Result-------------------");