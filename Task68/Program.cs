// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnterNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

int numM = EnterNumber("Введите число m: ");
int numN = EnterNumber("Введите число n: ");
if(numM >= 0 && numN >=0) 
{
    int akkerman = Akkerman(numM, numN);
    Console.WriteLine($"Значение чисел m - {numM} и n - {numN} в функции Аккермана составляет - {akkerman}");
}
else Console.WriteLine("Введено не корректное число M и N должны быть положительными числами");
