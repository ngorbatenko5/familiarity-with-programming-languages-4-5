﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int coefficient = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1  = InputLineData(line1);
double[] lineData2  = InputLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] COORD = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[coefficient]} * x + {lineData1[constant]} и y = {lineData2[coefficient]} * x + {lineData2[constant]}");
    Console.WriteLine($" Имеет координаты ({COORD[x_coord]}, {COORD[x_coord]})");
}

double Prompt(string message)
{
    Console.Write(message);
    string? value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[coefficient] = Prompt($"Введите коэффициент для {numberOfLine} прямой - ");
    lineData[constant] = Prompt($"Введите константу для {numberOfLine} прямой - ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] COORD = new double[2];
    COORD[x_coord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefficient] - lineData1[coefficient]);
    COORD[y_coord] =    lineData1[constant] * COORD[x_coord] + lineData1[constant];
    return COORD;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}
