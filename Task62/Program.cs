
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillMatrix(int[,] matrix, int row = 0, int column = 0, int currentItem = 1, bool directionControl = false)
{
    if (row < matrix.GetLength(0)
        && column < matrix.GetLength(1)
        && row >= 0
        && column >= 0)
    {
        if (directionControl == true && matrix[row, column] == 0)
        {
            if (matrix[row - 1, column] != 0)
            {
                FillMatrix(matrix, row, column, currentItem);
            }
            else
            {
                matrix[row, column] = currentItem;
                FillMatrix(matrix, row - 1, column, currentItem + 1, true);
            }
        }
        if (matrix[row, column] == 0)
        {

            matrix[row, column] = currentItem;
            FillMatrix(matrix, row, column + 1, currentItem + 1);
            FillMatrix(matrix, row + 1, column, currentItem + 1);
            FillMatrix(matrix, row, column - 1, currentItem + 1);
            FillMatrix(matrix, row - 1, column, currentItem + 1, true);

        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }

        Console.WriteLine();
    }
}


int[,] matr = new int[8, 7];
FillMatrix(matr);
PrintMatrix(matr);
