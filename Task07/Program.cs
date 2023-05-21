Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"{lastDigit} ");
}
else Console.WriteLine("Неверное число!");
