﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Enter number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = int.Parse(Console.ReadLine());

if (number2 == number1 / number2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}