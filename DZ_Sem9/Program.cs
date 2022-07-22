// Домашняя работа по семинару 9 С#. Байда Владимир.
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*int M = 5;
int N = 9;
Recursion(M, N);
Console.Write("\b\b ");

void Recursion(int M, int N)
{
    if (M > N)
    {
        return;
    } 
    else 
    {
        Console.Write(M + ", ");
        M++;
        Recursion(M, N);
    }
}
*/

//-----------------------------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*int M = 2;
int N = 5;
int sum = 0;
Console.Write($"Сумма натуральных элементов в промежутке от M={M} до N={N} равна {Recursion(M, N, sum)}");
int Recursion(int M, int N, int sum)
{
    if (M > N)
    {
        return sum;
    } 
    else 
    {
        sum +=M;
        M++;
        return Recursion(M, N, sum);
    }
}
*/

// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = 0;
int n = 1;
Console.Write(Akkerman(m, n));
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else // (m > 0 && n > 0)
    {
        return Akkerman(m-1, Akkerman(m, n - 1));
    } 
}
