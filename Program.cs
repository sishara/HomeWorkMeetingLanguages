// Урок 3. Базовые алгоритмы. Продолжение

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.WriteLine("Знакомство с языками программирования (семинары)");
Console.WriteLine("Урок 3. Базовые алгоритмы. Продолжение");

double result = 0;

int[] A = new int[3];
int[] B = new int[3];

Console.WriteLine("Input 3D coordinates for A");
// Нормализации данных пока не занимаемся по этому все проверки на не цифры и null пропускаю
for (int i = 0; i < A.Length; i++)
{
    A[i] = Convert.ToInt32(Console.ReadLine());
};
Console.WriteLine("Input 3D coordinates for B");

for (int i = 0; i < B.Length; i++)
{
    B[i] = Convert.ToInt32(Console.ReadLine());
};

result = Math.Round(Math.Sqrt(Math.Pow((A[0] - B[0]),2) + Math.Pow((A[1] - B[1]),2) + Math.Pow((A[2] - B[2]),2)),2);

Console.WriteLine("-------------------Result-------------------");
Console.WriteLine(result);
Console.WriteLine("-------------------Result-------------------");