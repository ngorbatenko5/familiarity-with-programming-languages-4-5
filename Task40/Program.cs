// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите длину А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину C");
int C = Convert.ToInt32(Console.ReadLine());

bool isExistTriangle = IsExistTriangle(A, B, C);
Console.WriteLine(isExistTriangle ? "Существует": "Не существует");

bool IsExistTriangle(int cide1, int cide2, int cide3)
{
    return cide1 < cide2 + cide3 && cide2 < cide3 + cide1 && cide3 < cide1 + cide2;
}
