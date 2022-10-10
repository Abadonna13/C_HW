// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int PrintMtoN(int m, int n)
{
    if (n < m)
    {
        if (m == n - 1)
        {
            return 0;
        }
        else return m + PrintMtoN(m - 1, n);
    }
    else if (n > m)
    {
        if (n == m - 1)
        {
            return 0;
        }
        else return n + PrintMtoN(m, n - 1);
    }
    else if (n == m) 
    {
        return m;
    }
    else return n;
}

int M = ReadNum("Введите M");
int N = ReadNum("Введите N");

Console.WriteLine(PrintMtoN(M, N));