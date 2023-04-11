// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int row = Prompt("Введите колличество строк: ");
int col = Prompt("Введите колличество столбцов: ");
int startValue = Prompt("Введите начало диапазона значения массива: ");
int endValue = Prompt("Введите конец диапазона значения массива: ");

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array);
Console.WriteLine();

int[] newArr = MatrixToArray(array);

Array.Sort(newArr);
PrintArray(newArr);
Console.WriteLine();

FrequencyDictonaryFromArray(newArr);

void FrequencyDictonaryFromArray(int[] array)
{
    int currenValue = array[0];
    int counter = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == currenValue) counter++;
        else 
        {
            Console.WriteLine($"{currenValue} -> {counter}");
            currenValue = array[i];
            counter = 1;
        }
    }
    Console.WriteLine($"{currenValue} -> {counter}");
}

int[] MatrixToArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[count] = matrix[i, j];
            count++;
        }
    }
    return newArray;
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
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

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" |");
    }
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

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
