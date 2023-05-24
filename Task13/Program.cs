// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int returnThirdDigit(int num)
{
    if(num < 0) num *= -1;
    if(num / 100 == 0) return -1;
    while(num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

System.Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
System.Console.Write($"{number} -> ");
int thirdDigit = returnThirdDigit(number);
System.Console.WriteLine(thirdDigit == -1 ? "There is no third digit" : thirdDigit);