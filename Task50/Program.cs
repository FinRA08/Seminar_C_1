// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int[] EnteringNumber()
{
    int[] arr = new int[2];
    Console.WriteLine("Для опредения значения элемента введите позицию элемнта");
    Console.Write("Укажите строку элемента: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    arr[0] = rows;
    Console.Write("Укажите столбец элемента: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    arr[1] = columns;
    return arr;
}

void DeterminingValueElem (int[,] matrix, int[] arr)
{
    if(arr[0] < 0 || arr[1] < 0) Console.WriteLine("Введено не верное значение строки или столбца - значение не может быть отрицательным");
    if(arr[0] >= matrix.GetLength(0) || arr[1] >= matrix.GetLength(1)) Console.WriteLine($"Позиция {arr[0]}, {arr[1]} -> такого элемента в массиве нет");
    else Console.WriteLine($"Позиция {arr[0]}, {arr[1]} содержит значение -> {matrix[arr[0],arr[1]]}");
}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
int[] enteringNumber = EnteringNumber();
DeterminingValueElem(array2d,enteringNumber);
