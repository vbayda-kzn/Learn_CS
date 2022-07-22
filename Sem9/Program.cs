// Семинар 9.
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N

/*int number = 15;
int count = 1;
Recursion(count, number);

void Recursion(int count, int number)
{
    if (count > number) return;
    Console.Write(count + " ");
    count++;
    Recursion(count, number);
}

// while (count <= number)
// {
//    Console.Write(count + " ");
//    count++
// } 
*/

//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*int M = 3;
int N = 8;
Recursion(M, N);

void Recursion(int M, int N)
{
    if (M > N)
    {
        return;
    } 
    else 
    {
        Console.Write(M + " ");
        M++;
        Recursion(M, N);
    }
}
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*int number = 1584;
Recursion(number);

int Recursion(int number)
{
    if (number / 10 > 0)
    {
        return Recursion(number /10) + number % 10;
    } 
    else 
    {
        return number;
    }
}
Console.WriteLine(Recursion(number));
*/

//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

/*int a = 4;
int b = 5;
Recursion(a, b);

void Recursion(int a, int b, int result = 1)
{
    if (b==0)
    {
        Console.WriteLine(result);
        return;
    }
    result *= a;
    b--;
    Recursion(a, b, result);
}
*/

// Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц (доделано)

Random rand = new Random();
int rowsFirst = rand.Next(3,7);
int columnesFirst = rand.Next(3,7);
int rowsSecond = columnesFirst;
int columnesSecond = rand.Next(3,7);

int[,] arrayFirst = new int [rowsFirst, columnesFirst];
int[,] arraySecond = new int [rowsSecond, columnesSecond];
int[,] arrayResult = new int [rowsFirst, columnesSecond];

FillArray(arrayFirst);
FillArray(arraySecond);
PrintArray(arrayFirst);
PrintArray(arraySecond);

for (int i =0; i < rowsFirst; i++)
{
    for (int j=0; j < columnesSecond; j++)
    {
        for (int k = 0; k < rowsSecond; k++)
        {
            arrayResult[i,j] += arrayFirst[i,k]*arraySecond[k,j];
        }
    }
}

PrintArray(arrayResult);

void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("+");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}