// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixTotal = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++) matrixTotal[i, j] += matrixA[i, k] * matrixB[k, j];

        }
    }
    return matrixTotal;

}

int[,] array2dA = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2dA);
Console.WriteLine();
int[,] array2dB = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(array2dB);
Console.WriteLine();
if (array2dA.GetLength(1) == array2dB.GetLength(0))
{
    int[,] totalMatrix = MatrixMultiplication(array2dA, array2dB);
    PrintMatrix(totalMatrix);
}
else Console.WriteLine("Для произведение матриц необходимо что бы число столбцов матрицы А была равна числу строк матрицы В");
