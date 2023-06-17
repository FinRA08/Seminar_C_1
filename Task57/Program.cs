// Задача 57 - Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз втречаетс элемент входных данных.

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

int[] MatrixToArray (int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[count] = matrix[i,j];
            count++;
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

void CountFrequencies (int[] arr)
{
    int currentNumber = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"Число {currentNumber} встречается {count} раз");
            currentNumber = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {currentNumber} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = MatrixToArray(array2d);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
CountFrequencies(array);
