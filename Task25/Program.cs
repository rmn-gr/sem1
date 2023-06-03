// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Power(int num, int pow)
{
    int sum = num;
    for (int i = 0; i < pow - 1; i++)
        sum *= num;
    return sum;
}


Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter power:");
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number},{power} -> " + Power(number, power));