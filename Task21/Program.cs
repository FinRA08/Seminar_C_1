// Напишите программу, которая 
// 1. принимает на вход координаты двух точек 
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter the coordinates of the first point");

Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the second point");

Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double myresalt = DistanceFromCoordinates(x1, y1, z1, x2, y2, z2);
myresalt = Math.Round(myresalt, 2, MidpointRounding.ToZero);
Console.Write($"Растояние между точкой с координатами X:{x1} Y:{y1} Z:{z1} и точкой с координатами X:{x2} Y:{y2} Z:{z2}");
Console.WriteLine($" составляет - {myresalt}");

double DistanceFromCoordinates (int ax, int ay, int  az, int bx, int by, int bz)
{
    double sumСathetus = (bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az);
    double d = Math.Sqrt(sumСathetus);
    return d;
}