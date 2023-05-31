// Напишите программу, которая 
// 1. принимает на вход число (N)
// 2. выдает твблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.Write("Enter a number N to get a table of squares of numbers from 1 to the entered number N: ");
int number = Convert.ToInt32(Console.ReadLine());

CalculatingASquare(number);

void CalculatingASquare (int num)
{
    if (num > 1)
    {     
        int count = 1;
        int sqare = 0;
        while(count <= num)
        {
            sqare = count * count;
            Console.WriteLine($"{count, 3} - {sqare, 4}");
            count++;
        }
    }else Console.WriteLine("The wrong number is entered, N must be > 0");
}