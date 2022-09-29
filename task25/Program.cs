// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

int ReadNum(string mess)
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int PowAinB(int a, int b)
{
    if (b >= 1)
    {
        int N = a;
        for (int i = 1; i < b; i++)
        {
            N = N * a;

        }
        return N;
    }
    else
    {
        Console.WriteLine("B должно быть не меньше 1!");
        return -1; 
    }
}

int number = ReadNum("Введите возводимое число А:");
int step = ReadNum("Введите натуральную степень В:");
int res = PowAinB(number, step);
Console.WriteLine($"Число {number} в натуральной степени {step} = {res}");