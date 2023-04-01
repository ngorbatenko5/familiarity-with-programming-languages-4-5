// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble (double[] arr)
{
Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
    if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Double difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    int i = 1;
    while (i < arr.Length)
    {
        if (max < arr[i])
        max = arr[i];
            if (min > arr[i])
            min = arr[i];
        i = i + 1;
}
return max-min;
}

double[] array = CreateArrayRndDouble(10, 50, 130);
PrintArrayDouble(array);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {difference(array)}");


