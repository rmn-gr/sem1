﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0) Console.Write($"{i} ");
    }
}
else
{
    Console.Write("Number isn't natural");
}