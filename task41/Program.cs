// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается 
// при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Запрос у пользователя
string ReadStr(string mess)
{
    Console.WriteLine(mess);
    return Console.ReadLine();
}

int count = 0;
while (true)
{
    string N = ReadStr("Введите число или stop:");
    if (N != "stop")
    {
        int num = Convert.ToInt32(N);
        if (num > 0)
        {
            count++;
        }
    }
    else
    {
        break;
    }

}
Console.WriteLine(count);