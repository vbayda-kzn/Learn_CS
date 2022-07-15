// ДЗ по семинару 6. Байда Владимир.
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами,
// округлёнными до одного знака.

/*
Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columnes = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний предел генерируемых значений: ");
int minRand = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний предел генерируемых значений: ");
int maxRand = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = Math.Round((rand.NextDouble() * (maxRand - minRand) + minRand), 1);
        }
    }
}

void PrintArray(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            
            Console.Write(string.Format("{0,6:F2}", array[i, j]) + "\t"); // не понял как выровнять по правому краю
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

//---------------------------------------------------------------------------------------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columnes = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний предел генерируемых значений: ");
int minRand = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний предел генерируемых значений: ");
int maxRand = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);

FindIndex(InputIndex(), array);


void FillArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = Math.Round((rand.NextDouble() * (maxRand - minRand) + minRand), 1);
        }
    }
}

void PrintArray(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(string.Format("{0,6:F2}", array[i, j]) + "\t"); // не понял как выровнять по правому краю
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] InputIndex()
{
    int[] index = new int[2];
    Console.Write("Введите индекс элемента 'i': ");
    index[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс элемента 'j': ");
    index[1] = Convert.ToInt32(Console.ReadLine());
    return index;
}

void FindIndex(int[] index, double[,] array)
{
    if (index[0] <= array.GetLength(0) && index[1] <= array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента массива с индексом ({index[0]}:{index[1]}) равно {array[index[0] - 1, index[1] - 1]}");
    }
    else Console.WriteLine($"В заданном массиве отсутствует элемент с индексом ({index[0]}:{index[1]})");
}
*/

//-----------------------------------------------------------------------------------------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columnes = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний предел генерируемых значений: ");
int minRand = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний предел генерируемых значений: ");
int maxRand = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columnes];
Random rand = new Random();

PrintArray(FillArray(array));
PrintComputeArray(ComputeArray(array));
Console.WriteLine();
Console.WriteLine();

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(minRand, maxRand);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(array[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ComputeArray(int[,] array)
{
    double[] srArifm = new double[columnes];
    for (int j = 0; j < columnes; j++)
    {
        double sum = 0;
        for(int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        srArifm[j] = sum / Convert.ToDouble(rows);
    }
    return srArifm;
}

void PrintComputeArray(double[] srArifm)
{
    Console.WriteLine("Среднее аримфетическое по столбцам: ");
    for (int i = 0; i < columnes; i++)
    {
        Console.Write(Math.Round(srArifm[i], 2) + "\t");
    }
}
