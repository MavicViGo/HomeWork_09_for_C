/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int akkerman(int m, int n)
{
    if (m == 0)
    {
      //  Console.WriteLine($"m={m}, n={n}");
        return n+1;

    }
    else if (m !=0 && n == 0)
    {
       // Console.WriteLine($"m={m}, n={n}");
        return akkerman(m - 1, 1);
    }
   
    else
    {
      //   Console.WriteLine($"m={m}, n={n}"); 
        return akkerman(m-1, akkerman(m,n-1));
    }
}


Console.Clear();
Console.Write("Введите число M: ");
int m =  int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n =  int.Parse(Console.ReadLine()!);

Console.WriteLine($"Ответ: {akkerman(m,n)}");