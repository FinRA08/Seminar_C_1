// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    Console.Write("Укажите количество планируемых к вводу чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
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

void FillingArray(int[] arr)
{
    Console.WriteLine("Введите числа для анализа");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
}

int DeterminingPositiveNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

int[] array = CreateArray();
FillingArray(array);
PrintArray(array);
int countPositivNum = DeterminingPositiveNumbers(array);
Console.WriteLine($"Введено следующее количество положителоьных чисел -> {countPositivNum}");