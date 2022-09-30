// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран. 
//Данные вводятся с консоли пользователем

int[] array = new int[8];
for(int n = 0; n < array.Length; n++)
{
    Console.WriteLine($"Введите элемент массива с индексом {n}");
    array[n] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введенный массив:");
foreach(int arr in array)
{
    Console.Write(arr + " ");
}