// 29. Напишите программу, которая задает массив
// из 8-ми элементов, выводит их на экран


int Prompt(string message)
{
    Console.WriteLine(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int [] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array) 
{
Console.WriteLine("[");
for (int i = 0; i < array.Length - 1; i++)
    {
        Console.WriteLine($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray(Length, min, max);
PrintArray(array);