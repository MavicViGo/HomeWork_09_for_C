/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int decrease(int a, int b, int s)
{
    if (b == a)
    {
        return s+b;
    }
//    Console.WriteLine($"a{a}, b{b}, s{s}");
    return decrease(a,b+1,s+b);
}


Console.Clear();
Console.Write("Введите число M: ");
int m =  int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n =  int.Parse(Console.ReadLine()!);

Console.WriteLine($"Ответ: {decrease(n,m,0)}");