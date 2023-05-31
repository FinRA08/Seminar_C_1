// Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Enter a number N to get a table of cube of numbers from 1 to the entered number N: ");
int number = Convert.ToInt32(Console.ReadLine());

CalculatingACube(number);

void CalculatingACube (int num)
{
    if (num > 1)
    {     
        int count = 1;
        int cube = 0;
        while(count <= num)
        {
            cube = count * count * count;
            Console.WriteLine($"{count} | {cube}");
            count++;
        }
    }else Console.WriteLine("The wrong number is entered, N must be > 0");
}