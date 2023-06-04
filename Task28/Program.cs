// Напишите программу которая:
// 1. Принимает на вход число N
// 2. Выдает произведение чисел от 1 до N

Console.Write("Enter a number to get the product of numbers from 1 to the entered number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("An incorrect number was entered, the entered number must be > 1");
    return;
}
int product = TheProductOfNumbers(number);
Console.WriteLine($"The product of numbers from 1 to {number} is equal to - {product}"); 


int TheProductOfNumbers (int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result = result * i;
        }      
    }
    return result;
}
