﻿// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int CountEvenElements(int[] arr)
{
    int Count = 0;
for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Count++;
        }
    }
return Count;    
}    

Random rand = new Random();
int randomSize = rand.Next(5, 20);
int[] array = GetArray(randomSize, 100, 999);
Console.WriteLine(string.Join(", ", array));
int Cou = CountEvenElements(array);
Console.WriteLine($"Количество четных чисел в массиве = {Cou}");