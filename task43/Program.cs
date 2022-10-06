// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Запрос числа у пользователя
double ReadNum(string mess)
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}


double  b1 = ReadNum("Введите b1:");
double  k1 = ReadNum("Введите k1:");
double  b2 = ReadNum("Введите b2:");
double  k2 = ReadNum("Введите k2:");

if(k1 != k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения ({x},{y})");
}
else
{
    Console.WriteLine("Прямые параллельны, точек пересечения нет");
}