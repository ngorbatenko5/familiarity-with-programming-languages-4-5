// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
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
        Console.Write("||");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("||");
    }
}

int[,] newMatrix = CreateMatrix(3, 3, 1, 10);
PrintMatrix(newMatrix);
Console.WriteLine($"Первая матрица:");
// Создал первую матрицу

int[,] CreateMatrix2(int rows2, int columns2, int min2, int max2)
{
    int[,] matrix2 = new int[rows2, columns2];
    Random rnd2 = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) //columns
        {
            matrix2[i, j] = rnd2.Next(min2, max2 + 1);
        }
    }
    return matrix2;
}

void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("||");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j],4} ");
        }
        Console.WriteLine("||");
    }
}

int[,] newMatrix2 = CreateMatrix2(3, 3, 1, 10);
PrintMatrix2(newMatrix2);
Console.WriteLine($"Вторая матрица:");
// Создал вторую матрицу



// Дальше не знаю...

int[,] MultiplicationMatrix(int[,] matrix, int[,] matrix2)
{
    resultMatrix = new int (matrix3);
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
         for (int j = i + 1; j < matrix2.GetLength(1); j++) 
         {
           for (int k = 0; k < matrix2.GetLength(0); k++)
           {
                resultMatrix[i, j] += matrix[i, k] * matrix2[k, j];
           }
           Console.Write(resultMatrix[i, j] + ", ");
         }
         Console.WriteLine();
     }
     return resultMatrix;
} 
