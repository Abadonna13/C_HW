// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNum(string mess)
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumOfDigits(int num)
{
    int sum = 0;
    if (num == 0) sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int number = ReadNum("Введите число:");
int sum = GetSumOfDigits(number);
Console.WriteLine(sum);