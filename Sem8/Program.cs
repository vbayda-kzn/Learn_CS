// Семинар 8 по С# 
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columnes = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
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
void ChangeArray(int[,] array)
{
    int temp = 0;
    for (int j = 0; j < columnes; j++)
    {
        temp = array[0, j];
        array[0, j] = array[rows - 1, j];
        array [rows - 1, j] = temp;
    }
}
*/

//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columnes = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
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
void ChangeArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        int temp;
        for(int j = i; j < columnes; j++)
        {
          (array[i, j], array[j, i]) = (array[j, i], array[i, j]); 
        }
    }
}
*/

//Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

/*

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columnes = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);
PrintDict(DictArray(array));

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
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
int[] DictArray(int[,] array)
{
    int[] dict = new int[10];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            dict[array[i,j]] += 1;  
        }
    }
    return dict;
}
void PrintDict(int[] dict)
{
    for (int i=0; i < dict.Length; i++)
    {
       if (dict[i] != 0) Console.WriteLine ($"элемент {i} встречается {dict[i]} раз.");
    }
}
*/



// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

/*Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columnes = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, columnes];
int[,] newArray = new int [rows - 1, columnes - 1];
Random rand = new Random();
int i_min = 0;
int j_min = 0;
FillArray(array);
PrintArray(array);
FindMinArray(array);
CutArray(array, newArray, i_min, j_min);
PrintArray(newArray);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++) array[i, j] = rand.Next(-10, 10);
    }
}
void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + "\t"); 
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinArray(int[,] array)
{
    int min = array [0, 0];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                i_min = i;
                j_min = j;
            }
        }
    }
    Console.WriteLine($"минимальный элемент находится на позиции {i_min}, {j_min}");
}

void CutArray(int[,] array, int[,] newArray, int i_min, int j_min)
{
    int bias_i = 0;
    for (int i = 0; i < rows - 1; i++)
    {
        int bias_j = 0;
        if (i == i_min) bias_i++;
        for(int j = 0; j < columnes - 1; j++)
        {
            if (j == j_min) bias_j++;
            newArray[i , j] = array[i + bias_i, j + bias_j];
        }
    }
}
*/