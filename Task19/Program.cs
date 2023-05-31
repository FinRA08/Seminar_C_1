// Напишите программу, которая 
// 1. принимает на вход пятизначное число 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a five digit number to determine if it is a polydron: ");
int number = Convert.ToInt32(Console.ReadLine());

DefinitionOnPolydron(number);

void DefinitionOnPolydron (int num)
{
    if (num < 0) num = num * -1;
    if (num >= 10000 && num <= 99999)
    {
        string printLine = (num % 10 == num / 10000 && num % 100 / 10 == num / 1000 % 10) ? "Yes" : "No";
        Console.WriteLine(printLine);
    }else Console.WriteLine("an incorrect number has been entered, the number must be five digits");
}