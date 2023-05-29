//Задача 18: Напишите программу, которая
// 1.по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер чеьверти от 1 до 4: ");
string quarter = Console.ReadLine();

string range = Quarter(quarter);
string result = range == null 
                ? "Введены неккоректные координаты"
                : $"Диапазон возможнных координат для указанной четверти: {range}";
Console.WriteLine(result);

string Quarter (string q)
{
    if (q == "1") return "x > 0 , y > 0";
    if (q == "2") return "x < 0 , y > 0";
    if (q == "3") return "x < 0 , y < 0";
    if (q == "4") return "x > 0 , y < 0";
    return null;
}