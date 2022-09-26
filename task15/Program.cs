// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1 || N > 7)
{
    Console.WriteLine("Нет такого дня недели!");
}
else
{
    if (N == 6 || N == 7)
    {
        Console.WriteLine("Ваходной");
    }
    else
    {
        Console.WriteLine("Рабочий");
    }
}