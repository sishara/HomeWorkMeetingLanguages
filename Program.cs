// ЗАДАЧА №715		
// Миша и негатив
// (Время: 1 сек. Память: 16 Мб Сложность: 17%)
// Миша уже научился хорошо фотографировать и недавно увлекся программированием. Первая программа, которую он написал, позволяет формировать негатив бинарного черно-белого изображения.

// Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, каждый из которых может быть либо черным, либо белым. Негатив такого изображения получается путем замены каждого черного пикселя на белый, а каждого белого пикселя – на черный.

// Миша, как начинающий программист, написал свою программу с ошибкой, поэтому в результате ее исполнения мог получаться некорректный негатив. Для того чтобы оценить уровень несоответствия получаемого негатива исходному изображению, Миша начал тестировать свою программу.

// В качестве входных данных он использовал исходные изображения. Сформированные программой негативы он начал тщательно анализировать, каждый раз определяя число пикселей негатива, которые получены с ошибкой.

// Требуется написать программу, которая в качестве входных данных использует исходное бинарное черно-белое изображение и полученный Мишиной программой негатив, и на основе этого определяет количество пикселей, в которых допущена ошибка.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит целые числа n и m (1 ≤ n, m ≤ 100) – высоту и ширину исходного изображения (в пикселях). Последующие n строк содержат описание исходного изображения. Каждая строка состоит из m символов «B» и «W». Символ «B» соответствует черному пикселю, а символ «W» – белому. Далее следует пустая строка, а после нее – описание выведенного Мишиной программой изображения в том же формате, что и исходное изображение.

// Выходные данные
// В выходной файл OUTPUT.TXT необходимо вывести число пикселей негатива, которые неправильно сформированы Мишиной программой.

// Примеры
// №	INPUT.TXT	OUTPUT.TXT
// 1	3 4
// WBBW
// BBBB
// WBBW

// BWWW
// WWWB
// BWWB	                    2
// 2	2  2
// BW
// BB

// WW
// BW	                    2



void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 7. Двумерные массивы. Доп задача №1236");
}

int[,] InputMishaFotoArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 2);
        }
    }

    return array;
}

string BlackOrWhite(int n)
{
    if (n == 0)
        return "B";

    return "W";
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(BlackOrWhite(array[i, j]) + "  ");
        }
        Console.WriteLine();
    }
}

int CalculateNumberOfErrors(int[,] array, int[,] negativeAarray)
{
    int errors = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == negativeAarray[i, j])
                errors++;
        }
    }
    return errors;
}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();

Console.WriteLine("Input Misha's photo width (px) 1 <= m <= 100:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Misha's photo hight (px) 1 <= m <= 100:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = InputMishaFotoArray(m, n);
int[,] negativeArray = InputMishaFotoArray(m, n);


Console.WriteLine("-------------------Result-------------------\n");
OutputArray(array);
Console.WriteLine("\n--------------------------------------------");
OutputArray(negativeArray);
Console.WriteLine($"Errors- {CalculateNumberOfErrors(array, negativeArray)}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------