// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int num = Prompt("Введите целое десятичное число");
int main = Prompt("Введите целое десятичное число основание системы исчисления");
Console.WriteLine(DecToBin(num, main)); 

int DecToBin(int number, int main)
{
    int res = 0;
    int multiplier = 1;
    while (number > 0)
    {
        res += (number % main) * multiplier;
        number = number / main;
        multiplier *= 10;
    }
    return res;
}
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine()); 
}
