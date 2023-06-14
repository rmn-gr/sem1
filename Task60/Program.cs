// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

const int MAX_COUNT_OF_ELEMENTS = 89;

int[,,] CreateArr3D(int rows, int columns, int depth)
{
    int[,,] arr = new int[rows, columns, depth];
    int[] itemsArray = new int[MAX_COUNT_OF_ELEMENTS];

    for (int i = 0; i < itemsArray.Length; i++)
    {
        itemsArray[i] = i + 10;
    }

    Random rnd = new Random();
    int leftIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int itemsArrayRndPos = rnd.Next(leftIndex, MAX_COUNT_OF_ELEMENTS);
                arr[i, j, k] = itemsArray[itemsArrayRndPos];
                itemsArray[itemsArrayRndPos] = itemsArray[leftIndex];
                leftIndex++;
            }
        }
    }
    return arr;
}


void PrintArr3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k],6} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

bool IsValidSize(int[,,] arr)
{
    return arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2) <= MAX_COUNT_OF_ELEMENTS;
}



int[,,] array = new int[4, 2, 2];
if (IsValidSize(array))
{
    array = CreateArr3D(array.GetLength(0), array.GetLength(1), array.GetLength(2));
    PrintArr3D(array);
}
else
{
    Console.WriteLine("Too big array!!!");
}
