// ЗАДАЧА №822
// Площадь треугольника
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не превышают 10 в 6  по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

// Примеры
// №	INPUT.TXT	    OUTPUT.TXT
// 1	2 1 2 4 6 1 	6
// 2	0 0 0 3 3 0	    4.5


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 6. Одномерные массивы. Продолжение. Доп ЗАДАЧА №822");
}

int[] InputCoordinates(int pointNumber)
{
    Console.WriteLine($"Input X , Y coordinates for point #{pointNumber}");
    int[] coord = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

    while (coord.Length < 2 || coord[0] > 1000000 || coord[1] > 1000000)
    {
        Console.WriteLine("Input correct coordinates");
        coord = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    }
    return coord;
}

double CalculateTriangleArea(int[] point1, int[] point2, int[] point3)
{
    return Convert.ToDouble(Math.Abs((point1[0] * (point2[1] - point3[1]) + point2[0] * (point3[1] - point1[1]) + point3[0] * (point1[1] - point2[1])))) / 2;
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
int[] point1 = InputCoordinates(1);
int[] point2 = InputCoordinates(2);
int[] point3 = InputCoordinates(3);


Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine(CalculateTriangleArea(point1, point2, point3));
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------