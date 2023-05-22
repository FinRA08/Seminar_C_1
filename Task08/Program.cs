/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число - программа покажет все четные числа от 1 до введеного Вами числа");
Console.Write("Введите положительное число > 1 - ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (number > 1)
{
    while (count <= number)
    {
        if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
        count++;
    }
    else count++;
    }
}
else Console.WriteLine("Некоректный ввод, число должно быть > 1");