// Напишите программу, которая 
// 1.принимает на вход число
// 2.выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("The program accepts a number as input and outputs the sum of the digits in the number");
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfNumbers = SumOfNumbers(number);
Console.WriteLine(sumOfNumbers);



int SumOfNumbers (int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10; 
    }
    return sum;
}