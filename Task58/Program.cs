// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




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

bool IsValidMatrixs(int[,] multipliedMatrix, int[,] multiplingMatrix)
{
    return multipliedMatrix.GetLength(1) == multiplingMatrix.GetLength(0);
}

int[,] MultiplyMatrixs(int[,] multipliedMatrix, int[,] multiplingMatrix)
{
    int newRows = multipliedMatrix.GetLength(0);
    int newColumns = multiplingMatrix.GetLength(1);
    int[,] newMatrix = new int[newRows, newColumns];

    for (int i = 0; i < newRows; i++)
    {
        for (int j = 0; j < newColumns; j++)
        {
            for (int k = 0; k < multipliedMatrix.GetLength(1); k++)
            {
                newMatrix[i, j] += multipliedMatrix[i, k] * multiplingMatrix[k, j];
            }
        }
    }


    return newMatrix;
}



int[,] matr1 = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(matr1);
 Console.WriteLine();

int[,] matr2 = CreateMatrixRndInt(5, 3, 0, 10);
PrintMatrix(matr2);
 Console.WriteLine();

if (IsValidMatrixs(matr1, matr2))
{
    int[,] multipledMatrix = MultiplyMatrixs(matr1, matr2);
    PrintMatrix(multipledMatrix);
}
else
{
    Console.WriteLine("You can't multiply these matrixs");
}