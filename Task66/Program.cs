// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int GetSumBetween(int m, int n) // 5
{
    if (m < n)
    {
        return m + GetSumBetween(m + 1, n);
    }
    else if (m > n)
    {
        return n + GetSumBetween(m, n + 1);
    }
    return m;
}

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int mNum = EnterNumber("Enter M");
int nNum = EnterNumber("Enter N");

int sum = 0;

sum = GetSumBetween(mNum, nNum);
Console.WriteLine($"M = {mNum}; N = {nNum} -> {sum}");
