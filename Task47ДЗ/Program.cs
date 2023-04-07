// Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int m = 3, n = 4;

double[,] matrix = new double[m, n]; // 0, 1
Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             matrix[i, j] = (double)rnd.Next(-50,  50) / 10;
             Console.Write($"{matrix[i, j], 7}");
        }
        Console.WriteLine();
    }