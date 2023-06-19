// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

bool IsNatural(int num)
{
    return num > 0;
}

void NaturalNumbers(int num) // 5
{
if (num == 0) return;
Console.Write($"{num} ");
NaturalNumbers(num - 1);
}

Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
if(IsNatural(number))
{
NaturalNumbers(number);
}
else
{
    Console.WriteLine("Number isn't natural");
}