// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

double[] GetColumnsAverage(int[,] matrix)
{
    double[] avgArray = new double[matrix.GetLength(1)];
    double tmpColumnSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            tmpColumnSum += matrix[i,j];
        }
        avgArray[j] = tmpColumnSum / matrix.GetLength(0);
        tmpColumnSum = 0;
    }
    return avgArray;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

void RoundArray(double[] arr, int round = 1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i], round);
    }
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
double[] avgColumnsArray = GetColumnsAverage(matr);
RoundArray(avgColumnsArray);
System.Console.Write("Every column's avg are: ");
PrintArray(avgColumnsArray);