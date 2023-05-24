// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowSecondDigit(int num)
{
    return num / 10 % 10;
}

System.Console.WriteLine("Enter number with 3 digits: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000) System.Console.WriteLine($"{number} -> {ShowSecondDigit(number)}");
