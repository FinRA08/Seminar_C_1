// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndInt(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MaxValue (double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double MinValue (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndInt(5, 0, 100);
PrintArray(array);
double maxValue = MaxValue(array);
Console.WriteLine($"Максимальное значение массива - {maxValue}");
double minValue = MinValue(array);
Console.WriteLine($"Минимальное значение массива - {minValue}");
double differenceMaxMin = maxValue - minValue;
Console.WriteLine($"Разница между максимальным значением и минимальным значением составляет - {differenceMaxMin}");