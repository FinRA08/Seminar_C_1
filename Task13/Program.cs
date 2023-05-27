/* Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите число и программа выведет третью цифру заданного числа или сообщит что третьей цифры нет: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    int myresalt = IsolationOfTheThirdNumber(number);
    Console.WriteLine($"Третье число числа - {number}, это - {myresalt}");
}
else Console.WriteLine("Третьей цифры нет");

int IsolationOfTheThirdNumber (int num)
{
    if (num >= 100)
    while (num >= 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}