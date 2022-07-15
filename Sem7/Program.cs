// Семинар 7 по С#
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*int rows = 4;
int columnes = 5;
int[,] array = new int[rows, columnes];
Random rand = new Random();
FillArray(array);
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
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
*/

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.


/*int rows = 4;
int columnes = 5;
int[,] array = new int[rows, columnes];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = i + j;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
*/

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.


/*int rows = 10;
int columnes = 10;
int[,] array = new int[rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(0, 9);
            if ((i%2==0) && (j%2==0))
            {
              array[i, j] *= array[i,j]; 
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
*/

// Задача 51: Задайте двумерный массив. Найдите сумму 
//элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int rows = 5;
int columnes = 5;
int[,] array = new int[rows, columnes];
Random rand = new Random();
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма чисел по диаганали равна {EditArray(array)}");

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(0, 9);
        }
    }
}

int EditArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < columnes && i < rows; i++)
    {
        sum += array[i, i];
    }
    return sum;
}
  
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}