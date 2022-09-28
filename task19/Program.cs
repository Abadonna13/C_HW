// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число N");
int N = Convert.ToInt32(Console.ReadLine());
if (10000 <= N && N < 100000)
{
    int tempN = N;//число, которое мы будем делить на 10
    int revN = 0; // развернутое число
    while (tempN > 0)
    {
        int digit = tempN % 10;
        revN = revN * 10 + digit;
        tempN = tempN / 10;
    }
    if (N == revN)
    {
        Console.WriteLine($"Развернутое число = {revN}, полиндром числа {N}");
    }
    else
    {
        Console.WriteLine($"Развернутое число = {revN}, не полиндром числа {N}");
    }
}
else
{
    Console.WriteLine("Введено не верное число!");
}