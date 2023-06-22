// Задача 69: Напишите программу, которая на вход принимает два числа А и В, и вoзводит число А в целую степень В с помощью рекурсии.
// А = 3; В = 5 -> 243 (3/5)
// А = 2; В = 3 -> 8

int EnterNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Exp (int num, int expi)
{
    if(expi == 0) return 1;
    return num * Exp(num, expi - 1);
}

int numberA = EnterNumber("Введите натуральное число А: ");
int numberB = EnterNumber("Введите натуральное число B: ");
int exp = Exp(numberA, numberB);
Console.WriteLine($"Целая степень числа - {numberA} возведенного в степень - {numberB} равна -> {exp}");