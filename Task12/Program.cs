// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remainder(int num1, int num2)
{
    int rem = num1 % num2;
    return rem;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);
string printLine = remainder == 0 ? "Кратно" : $"не кратно, остаток {remainder}";
Console.WriteLine(printLine);
