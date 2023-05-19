// 0. Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Square of {number} - " + Math.Pow(number, 2));