// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintNto1(int n, int count)
{
        if(n < count)
    {
        return;
    }
    else
    {
        PrintNto1(n, count+1);
        Console.Write(count + " ");
    }
}

int number = ReadNum("Введите N");
PrintNto1(number, 1);