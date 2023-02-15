// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 6. Одномерные массивы. Продолжение.Задача 41 ");
}

int ConutNumbersBiggerThanZero(string[] array)
{
    int result = 0;

    foreach (string item in array)
        if (Convert.ToInt32(item) > 0) result++;

    return result;
}

PrepareProgramHeader();

string[] array = Console.ReadLine().Split(" ");

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"{ConutNumbersBiggerThanZero(array)}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------