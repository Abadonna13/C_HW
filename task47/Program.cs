// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Запрос числа у пользователя
int ReadNum(string mess)
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    double[,] matrix = new double[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.NextDouble()+rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,5:f1} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int m = ReadNum("Введите количество строк");
int n = ReadNum("Введите количество столбцов");
double[,] matr = GetMatrix(m, n);
PrintMatrix(matr);