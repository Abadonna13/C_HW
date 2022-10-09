// Запрос числа у пользователя
int ReadNum(string mess)
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}


// Создание массива и заполнение его случайными значениями
int[] GetArray(int size, int leftRange,  int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}


// Нахождение экстремумов в массиве
(int, int) FindMinAndMax(int[] arr)
{
    int Min = arr[0];
    int Max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < Min) Min = arr[i];
        if (arr[i] > Max) Max = arr[i];
    }
    return (Min, Max);
}


// Разворот масива

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


// Пример рекурсии: перевод числа с десятичного в двоичный
void PrintBinaryView(int number)
{
    if(number <= 0) 
    {
        return;
    }
    PrintBinaryView(number / 2);
    Console.Write(number % 2);
}

// Заполнение двухмерной матрицы рандом
int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
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


// Вывод на печать матрицы
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}