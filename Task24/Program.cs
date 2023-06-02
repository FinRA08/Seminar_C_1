// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А)
// 2. выдаёт сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int resalt = Sumnumbers(number);
Console.WriteLine(resalt);


int Sumnumbers (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;// sum += i
    } 
    return sum;
}

