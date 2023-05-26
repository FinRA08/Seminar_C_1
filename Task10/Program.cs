/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число и программа выведет вторую цифру этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int myresilt = ReflectionOfTheSecondNumber(number);
    Console.WriteLine(myresilt);

}
else Console.WriteLine("Введено не корректное число, программа принимает на вход только трухзначное число");


int ReflectionOfTheSecondNumber(int num)
{
    int result = num % 100 / 10;
    return result;
}