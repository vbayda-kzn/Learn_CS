// Домашняя работа к семинару 8 по C#. Байда Владимир
// Задача 58. Заполните спирально массив 4 на 4 - не мог начать не с нее))

/*Console.Clear();
Console.WriteLine("--------------------------------------------------------------------------" );

int[,] array = new int [7, 7]; // можно заполнять любые любые квадратные матрицы 
array[0,0] = 1;
int count = 0;
int[] down = {1, 0};
int[] up = {-1, 0};
int[] right = {0, 1};
int[] left = {0, -1};
int[] direct = right;
int k = 0;
int i = 0;
int j = 0;

Console.CursorVisible = false;
Console.SetCursorPosition(5, 2);
Console.WriteLine(array[0, 0]);

for (k = 2; k <= array.Length; k++) // в один цикл))
{
    count++;
    Move(count, array);
}

Console.SetCursorPosition(0, Console.WindowHeight);
Console.WriteLine();
Console.CursorVisible = true;

int[] Turn (int[] direct)
{
    // Console.WriteLine($"Меняем направление direct = {direct[0]}:{direct[1]}");
    if (direct.SequenceEqual(right)) direct = down;
    else if (direct.SequenceEqual(down)) direct = left;
    else if (direct.SequenceEqual(left)) direct = up;
    else  direct = right;
    count = 1;
    return direct;
}

int[,] Move(int count, int[,] array)
{
    i += direct[0];
    j += direct[1];
    
    if (i > array.GetLength(0) - 1 || j > array.GetLength(1)-1 || j < 0)
    {
        i -= direct[0];
        j -= direct[1];
        direct = Turn(direct);
        i += direct[0];
        j += direct[1];
    }
    else if (array[i, j] != 0)
    {
        i -= direct[0];
        j -= direct[1];
        direct = Turn(direct);
        i += direct[0];
        j += direct[1];
    };
   
    
    array[i, j] = k; // запись числа в массив

    
    // блок визуализации
    Thread.Sleep(100);
    Console.SetCursorPosition(j*4 + 5, i*2 + 2);
    Console.WriteLine(array[i, j]);
    
    return array;
}

*/          
                       
//----------------------------------------------------------------------------------
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

/*Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
int[,] array = new int[4, 4]; // здесь задаем размерность массива
int minRand = 0; // задаем миниальное значение элемента массива
int maxRand = 10; // задаем максимальное значение элемента массива
Random rand = new Random();
int rows = array.GetLength(0);
int columnes = array.GetLength(1);

FillArray(array);
PrintArray(array);
SortByRowArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(minRand, maxRand);
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

void SortByRowArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columnes-1; j++)
        {
            for (int t = 0; t < columnes-j-1; t++)
            {
                if (array[i, t] < array[i, t + 1])
                {
                    int temp = array[i,t];
                    array[i,t] = array[i,t+1]; 
                    array[i,t+1] = temp;
                } 
           }
        }
    }
}
*/



//-----------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
int[,] array = new int[3, 4]; // здесь задаем размерность массива
int minRand = 0; // задаем миниальное значение элемента массива
int maxRand = 10; // задаем максимальное значение элемента массива
Random rand = new Random();
int rows = array.GetLength(0);
int columnes = array.GetLength(1);

FillArray(array);
PrintArray(array);
FindMinSumRow(array);
Console.WriteLine();
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columnes; j++)
        {
            array[i, j] = rand.Next(minRand, maxRand);
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

void FindMinSumRow(int[,] array)
{
    
    int minIndex = 0;
    int sumRowMin = 0;
    int sumRow = 0;

    for (int i = 0; i < rows; i++)
    {
        sumRow = 0;

        for (int j = 0; j < columnes; j++)
        {
            sumRow += array[i,j]; 
        }
        
        if (i == 0)
        {
            sumRowMin = sumRow;
            minIndex = i;
        } 
        else
        {
            if (sumRowMin > sumRow)
            {
                sumRowMin = sumRow;
                minIndex = i;
            }
        } 
        Console.WriteLine($"Сумма {i+1}-й строки массива равна {sumRow}");
    }
    Console.WriteLine($"Наименьшее значение суммы элементов имеет {minIndex+1}-я строка массива - {sumRowMin}");
}
*/