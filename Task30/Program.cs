// Напишите программу которая -
// 1. Выводит массив из 8 элементов
// 2. Заполненый нулями и единицами в случайном порядке

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);


