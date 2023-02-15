// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




void PrepareProgramHeader()
{
    Console.Clear();
    Console.WriteLine("Знакомство с языками программирования (семинары)");
    Console.WriteLine("Урок 6. Одномерные массивы. Продолжение.Задача 43");
}

double[] InputParametres()
{   
    double[] result = new double[4];
    Console.Write("k1 ="); result[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("b1 ="); result[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 ="); result[2] = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 ="); result[3] = Convert.ToInt32(Console.ReadLine());

    return result;
}

double FindXIntersection(double[] parameters)
{ 
    return (parameters[3] - parameters[1]) / (parameters[0] - parameters[2]);
}

double FindYIntersection(double[] parameters)
{
    return parameters[0] * ((parameters[3] - parameters[1]) / (parameters[0] - parameters[2])) + parameters[1];
}
string FindIntersection(double[] parameters)
{
    
    if(parameters[0] == parameters[2])
    {
        if (parameters[1] == parameters[3])
            return "The lines coincide";
        else
            return "The lines are paralell";
    }

    return $"({FindXIntersection(parameters).ToString()}; {FindYIntersection(parameters).ToString()})";
}


// ---------------------- MAIN PROGRAM -------------------------
PrepareProgramHeader();
double [] parameters = InputParametres();

Console.WriteLine("-------------------Result-------------------\n");
Console.WriteLine($"{FindIntersection(parameters)}");
Console.WriteLine("\n-------------------Result-------------------");

// ---------------------- MAIN PROGRAM -------------------------