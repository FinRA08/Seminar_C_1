// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnterNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers (int num1, int num2)
{
    if(num1 >= 0 && num2 >= 0)
    {
        if (num1 < 0 || num2 < 0) return 0;
        if (num1 < num2) return (num1 + SumNumbers(num1 + 1, num2));
        if (num1 > num2) return (num1 + SumNumbers(num1 - 1, num2));
        if (num1 == num2) return num1;
        else return -1;
    }
    else return -1;
}

int numberA = EnterNumber("Введите натуральное  число A: ");
int numberB = EnterNumber("Введите натуральное  число B: ");
int sum = SumNumbers(numberA, numberB);
if (sum < 0)
{
    Console.WriteLine("Введено не коректное число, число А и В должны быть >= 0");
}
else Console.WriteLine($"Сумма чисел в промежутке от {numberA} до {numberB} равна {sum}");