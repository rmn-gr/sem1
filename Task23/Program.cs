// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void WriteLinesThirdPower(int number)
{
    for (int i = 1; i <= number; i++)
    {
        int square = i * i * i;
        Console.WriteLine($"{i,3} | {square,4}");
    }
}

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteLinesThirdPower(number);
