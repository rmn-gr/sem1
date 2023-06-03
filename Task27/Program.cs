﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumOfDigits(int num)
{
    int sum = 0;
    while(num != 0)
    {
        sum += num%10;
        num /= 10;
    }
    return sum;
}


Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} -> " + GetSumOfDigits(number));