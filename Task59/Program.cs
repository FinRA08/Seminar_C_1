// Задание 59 - Задайте двемерный массив из целых чисел
// Напишите программу, которая удалит строку и столбец
// на пересечении которых расположен наименьший элемент массива

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

int[] IndexMinElem(int[,] matrix)
{
    int[] minIndex = new int[2];
    int minElem = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if(minElem > matrix[i,j])
            {
                minElem = matrix[i,j];
                minIndex[0] = i;
                minIndex[1] = j;
            } 
        }
    }
    return minIndex;
}

int[,] RemoveRowCol(int[] index, int[,] matrix)
{
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1) - 1;
    int[,] newMatrix = new int [rows, columns];
    
    int m = 0;
    for (int i = 0; i < rows; i++)
    {
        if(m == index[0]) m++;
        int n = 0;
        
        for (int j = 0; j < columns; j++)
        {
            if(n == index[1]) n++;
            newMatrix[i,j] = matrix[m,n];
            n++;
        }
        m++;
    }
    return newMatrix;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] indexMinElem = IndexMinElem(array2d);
int[,] array2dNew = RemoveRowCol(indexMinElem, array2d);
PrintMatrix(array2dNew);
