//Напишите программу, которая:
//1. принимает на вход координаты двух точек
//2. находиит растояние между ними в 2D пространстве
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
// Теорема пифагора

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double myresalt = DistanceFromCoordinates(x1, y1, x2, y2);
myresalt = Math.Round(myresalt, 2, MidpointRounding.ToZero);
Console.Write($"Растояние между точкой с координатами X:{x1} Y:{y1} и точкой с координатами X:{x2} Y:{y2} ");
Console.WriteLine($"составляет - {myresalt}");

double DistanceFromCoordinates (int ax, int ay, int bx, int by)
{
    double sumСathetus = (bx - ax) * (bx - ax) + (by - ay) * (by - ay);
    double d = Math.Sqrt(sumСathetus);
    return d;
}