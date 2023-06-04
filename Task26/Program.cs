// Задача 26: Напишите программу которая
// 1. Принимает на вход целое число
// 2. выводит колическтво цифр в веденом числе
// 123 -> 3
// 5475 -> 4
// 5 -> 1

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int resaltDigitsNumber = DigitsInNumber(number);
Console.WriteLine($"{number} contains {resaltDigitsNumber} digits");


int DigitsInNumber (int num)
{
    int digits = 0;
    if (num == 0) return 1;
    while (num != 0)
        {
            digits++;
            num /= 10;
        }
    return digits;
}

