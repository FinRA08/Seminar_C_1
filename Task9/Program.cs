/* Напишите программу, которая:
1. выводит случайное число из отрезка [10, 99] и
2. показывает наибольшую цифру числа. */

// 78 -> 8  78/10 =7.8 in int = 7
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;
// int seconDigit = number % 10;

// if (firstDigit > seconDigit) 
//     Console.WriteLine($"Наибольшая цифрв числа -> {firstDigit}");
// else 
//     Console.WriteLine($"Наибольшая цифрв числа -> {seconDigit}");


// int maxDigit = firstDigit > seconDigit ? firstDigit : seconDigit;
// Console.WriteLine($"Наибольшая цифрв числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифрв числа -> {maxDigit}");

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int seconDigit = num % 10;
    int maxDigit = firstDigit > seconDigit ? firstDigit : seconDigit;

    return maxDigit;
}