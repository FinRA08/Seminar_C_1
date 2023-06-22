// напишите программу, которая будет принимать на вход число и возвращать сумму ешл цифр
// 453 -> 12
// 45 -> 9

int EnterNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits (int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigits(num / 10);
}

int number = EnterNumber("Введите натуральное число: ");
int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма чисел чесла -> {number} = {sumDigits}");

