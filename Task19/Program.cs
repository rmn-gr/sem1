// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int ReverseNumber(int number)
{
    int numOfDigits = 0;
    int reverseNumber = 0;
    for (int i = number; i != 0; i /= 10, numOfDigits++) ;
    for (int i = numOfDigits - 1; i >= 0; i--)
    {
        reverseNumber += (number % 10) * (int)Math.Pow(10, i);
        number /= 10;
    }
    return reverseNumber;
}

System.Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
if (num >= 10000 && num <= 99999)
{
    System.Console.Write($"{num} -> ");
    if (num == ReverseNumber(num))
    {
        System.Console.Write("Yes");
    }
    else
    {
        System.Console.Write("No");
    }
}
else
{
    System.Console.WriteLine("Wrong number");
}