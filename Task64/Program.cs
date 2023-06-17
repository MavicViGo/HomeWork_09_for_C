/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string decrease(int a, int b)
{
    if (b == a)
    {
        return $"{b}";
    }
    return decrease(a,b + 1) + $", {b}";
}


Console.Clear();
Console.Write("Введите число N: ");
int n =  int.Parse(Console.ReadLine()!);
Console.WriteLine(decrease(n,1));