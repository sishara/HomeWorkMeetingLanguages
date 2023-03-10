// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 8. Двумерные массивы. Продолжение . Задача 62");
}

string FillTwoDigits(int number)
{
    if (number.ToString().Length > 1)
        return number.ToString();

    return $"0{number}";
}
void OutputTwoDimensionalArray(string[,] array)
{
    int length1 = array.GetLength(0);
    int length2 = array.GetLength(1);
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}





string[,] SpiraleTriangale()
{
    string[,] spiral = new string[4, 4];
    int value = 1;

    int top = 0, bottom = 3, left = 0, right = 3; 
    int direction = 0; 

    while (top <= bottom && left <= right)
    {
       
        if (direction == 0)
        {
            for (int i = left; i <= right; i++)
            {
                spiral[top, i] = FillTwoDigits(value++);
            }
            top++;
        }
       
        else if (direction == 1)
        {
            for (int i = top; i <= bottom; i++)
            {
                spiral[i, right] = FillTwoDigits(value++);
            }
            right--;
        }
       
        else if (direction == 2)
        {
            for (int i = right; i >= left; i--)
            {
                spiral[bottom, i] = FillTwoDigits(value++);
            }
            bottom--;
        }
       
        else if (direction == 3)
        {
            for (int i = bottom; i >= top; i--)
            {
                spiral[i, left] = FillTwoDigits(value++);
            }
            left++;
        }

        direction = (direction + 1) % 4; // change direction
    }

    return spiral;

}

// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
Console.WriteLine("-------------------Result-------------------\n");
OutputTwoDimensionalArray(SpiraleTriangale());
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------