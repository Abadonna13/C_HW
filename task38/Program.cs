// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

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

Random rand = new Random();
int randomSize = rand.Next(5, 20);
int[] array = GetArray(randomSize, 1, 100);
Console.WriteLine(string.Join(", ", array));
(int Minarr, int Maxarr) = FindMinAndMax(array);
Console.WriteLine($"Разница между максимальным (= {Maxarr}) и минимальным (= {Minarr}) элементами массива = {Maxarr - Minarr}");