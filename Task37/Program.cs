// See https://aka.ms/new-console-template for more information


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] MultiplyElements(int[] arr)
{
    int newLength = arr.Length / 2;
    if (arr.Length % 2 == 1) newLength += 1;
    int[] newArr = new int[newLength];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArr[newLength - 1] = arr[arr.Length / 2];
    return newArr;
}

int[] array = CreateArrayRndInt(5, 0, 10);
PrintArray(array);
int[] array2 = MultiplyElements(array);
PrintArray(array2);
