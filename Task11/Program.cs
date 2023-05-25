﻿// 11.Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteSecondDihit (int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}

int number = new Random().Next(100, 1000);

Console.WriteLine($"Трехзначное число - {number}");
int deleteSecondDigit = DeleteSecondDihit(number);
Console.WriteLine($"Число без второй цифры - {deleteSecondDigit}");