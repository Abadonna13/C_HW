// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int ReadNum(string mess)
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -20, int rightRange = 20)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Random rand = new Random();
int m = rand.Next(1,15); //количество строк
int n = rand.Next(1,15); //количество столбцов
int[,] matr = GetMatrix(m, n);
int M = ReadNum("Введите номер сроки");
int N = ReadNum("Введите номер столбца");
PrintMatrix(matr);
Console.WriteLine();
if (M < matr.GetLength(0) && N < matr.GetLength(1) && M>=0 && N >=0)
{
Console.WriteLine($"Искомый элемент ({M},{N}) равен {matr[M, N]}");
}
else Console.WriteLine($"({M},{N}) -такого числа в массиве нет");