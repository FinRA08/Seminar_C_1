// Задача 65: Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> 1 2 3 4 5
// M = 4; N = 8 -> 4 5 6 4 8

int EnterNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ConsecutiveNumbersInRange (int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        ConsecutiveNumbersInRange(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        ConsecutiveNumbersInRange(num1 - 1, num2);
    }
    else Console.Write($"{num1}");
}

int numberM = EnterNumber("Введите значение M: ");
int numberN = EnterNumber("Введите значение N: ");
ConsecutiveNumbersInRange(numberM, numberN);