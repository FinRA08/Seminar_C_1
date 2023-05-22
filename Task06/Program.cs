/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число - программа определит является ли оно четным");
Console.Write("Введите число не равное нулю - ");
int number = Convert.ToInt32(Console.ReadLine());

if (number != 0)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} - четное число");
    }
    else Console.WriteLine($"{number} - нечетное число");
}
else Console.WriteLine("Некоректный ввод, введен 0");
