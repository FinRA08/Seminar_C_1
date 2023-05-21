Console.Write("Введите число, соответствующее дню недели - ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Понедильник");
}

else if (num == 2)
{
    Console.WriteLine("Вторник");
}

else if (num == 3)
{
    Console.WriteLine("Среда");
}

else if (num == 4)
{
    Console.WriteLine("Четверг");
}

else if (num == 5)
{
    Console.WriteLine("Пятница");
}

else if (num == 6)
{
    Console.WriteLine("Суббота");
}

else if (num == 7)
{
    Console.WriteLine("Воскресенье");
}

else Console.WriteLine("В недели всего 7 дней, используйте от 1 до 7");