
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsDayAWeekend(int day)
{
    return day == 6 || day == 7 ? true : false;
}

System.Console.WriteLine("Enter day number:");
int dayOfWeek = int.Parse(Console.ReadLine());
if(dayOfWeek<=7 && dayOfWeek >=1 )
{
    System.Console.WriteLine(IsDayAWeekend(dayOfWeek)? "Yes" : "No");
}
else
{
    System.Console.WriteLine("Wrong number");
}