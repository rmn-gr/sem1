// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] EnterCoefficients(string msg)
{
    double[] line = new double[2];
    Console.Write($"Enter k for {msg}: ");
    line[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Enter b for {msg}: ");
    line[1] = Convert.ToDouble(Console.ReadLine());
    return line;
}

double[] GetCrossing(double[] ln1, double[] ln2)
{
    double[] crossing = new double[2];
    crossing[0] = (ln1[1] - ln2[1]) / (ln2[0] - ln1[0]);
    crossing[1] = (crossing[0] * ln1[0]) + ln1[1];
    return crossing;
}


double[] line1 = EnterCoefficients("Line 1");
double[] line2 = EnterCoefficients("Line 2");

double[] crossingPoint = GetCrossing(line1, line2);

Console.WriteLine($"({crossingPoint[0]}, {crossingPoint[1]})");