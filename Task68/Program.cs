// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1


int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));

}


int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int mNum = EnterNumber("Enter M");
int nNum = EnterNumber("Enter N");

Console.WriteLine($"M = {mNum}; N = {nNum} ->  A(m,n) {AkkermanFunction(mNum, nNum)}");
