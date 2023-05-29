/* Задача 15: Напишите программу, которая 
принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число соответствующее дню недели, программа выведет являеется ли этот день выходным - ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 7)
{
    Console.WriteLine(DefinitionOfADayOff(day));
}
else Console.WriteLine("Ввудено не коректное число, необходимо указать от 1 до 7");




string DefinitionOfADayOff (int days)
{
    if (days >= 1 && days <=5)
    {
        return "нет";
    }
    else return "да";
    
}