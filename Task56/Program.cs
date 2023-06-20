// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix [i,j], 5}");
        }
        Console.WriteLine();
    }
}

int[] CalculSumLine (int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[i] = arr[i] + matrix[i,j];
        }
    }
    return arr;
}

void PrintArray (int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]} {sep}");
        else Console.WriteLine($"{arr[i]}");
    }
}

int DeterminMinElem (int[] arr)
{
    int rowsMin = 0;
    int minElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(minElem > arr[i])
        {
            minElem = arr[i];
            rowsMin = i + 1;
        }
        
    }
    return rowsMin;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = CalculSumLine(array2d);
PrintArray(array);
int minRows = DeterminMinElem(array);
Console.WriteLine($"Наименьшая сумма элементов в {minRows} строке");