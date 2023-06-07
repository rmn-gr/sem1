// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}




int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


int[] CreateUserArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i+1} element: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }
    return arr;
}

Console.Write("Enter size of array: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateUserArray(5);
PrintArray(array);
Console.Write(" -> " + CountPositiveNumbers(array));