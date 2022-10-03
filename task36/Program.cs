﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOddPositionElements(int[] arr)
{
    int Sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {

        Sum += arr[i];

    }
    return Sum;
}

Random rand = new Random();
int randomSize = rand.Next(5, 20);
int[] array = GetArray(randomSize, 0, 100);
Console.WriteLine(string.Join(", ", array));
int SumOdd = SumOddPositionElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumOdd}");