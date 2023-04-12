// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(number1, number2);

int NaturalNumbersRange(int num1, int num2)
{
  if (num1 == num2) return num1;
  else return NaturalNumbersRange(num1 + 1, num2) + num1;
}
Console.WriteLine();
Console.WriteLine($"Cумма натуральных элементов в промежутке от {number1} до {number2} равна {NaturalNumbersRange(number1, number2)}");