// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
    arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
    if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int GetSumElemOddPositions(int[] arr)
{
int sum = 0;
int i = 1;
    while (i < arr.Length)
    {
        sum = sum + arr[i];
        i = i + 2;
    }
    return sum;
}

int[] array = CreateArrayRndInt(10, -7, 9);
PrintArray(array);
int sumElemOddPositions = GetSumElemOddPositions(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumElemOddPositions}");