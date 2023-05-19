// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.Write(number % 10);
}
else Console.Write("Wrong number");