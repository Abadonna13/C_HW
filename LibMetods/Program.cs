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

//