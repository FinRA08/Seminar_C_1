// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int EnterNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int num)
{
    if(num >= 0)
    {
        if(num == 0) return;
        Console.Write($"{num} ");
        NaturalNumbers(num - 1);
    }
    else Console.WriteLine("Введено не коректное число, чило N должно быть > 0");
}

int number = EnterNumber("Введите натуральное  число: ");
NaturalNumbers(number);
