//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*void Zadacha34()
{
    int[] array = new int[10];
    Random rand = new Random();
    int count = 0;

    FillRandArray(array);
    PrintArray(array);
    CountEvenNumbers(array);
    PrintCountEvenNumbers(count);

    int[] FillRandArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100, 1000);
        }
        return array;
    }
    
    void PrintArray (int[] array)
    {
        Console.WriteLine();
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
    }

    int CountEvenNumbers(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
           if (array[i] % 2 == 0) count++;
        }
        return count;
    }

    void PrintCountEvenNumbers(int count)
    {
        Console.WriteLine($"В сгенерированном нами массиве четных чисел аж {count} штук(и)!");
        Console.WriteLine();
    }
}

Zadacha34 ();
*/


//----------------------------------------------------------------------------------------------------------------------------------------
// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*void Zadacha36()
{
    int[] array = new int[6];
    Random rand = new Random();
    int sumOddPos = 0;

    FillRandArray(array);
    PrintArray(array);
    FnSumOddPos(array);
    PrintSumOddPos(sumOddPos);

    int[] FillRandArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-9, 10);
        }
        return array;
    }
    
    void PrintArray (int[] array)
    {
        Console.WriteLine();
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
    }

    int FnSumOddPos(int[] array)
    {
        for(int i = 0; i < array.Length; i += 2)
        {
           sumOddPos += array[i];
        }
        return sumOddPos;
    }

    void PrintSumOddPos(int OddEvenPos)
    {
        Console.WriteLine($"В сгенерированном нами массиве сумма чисел на нечетных позициях равна {sumOddPos}!");
        Console.WriteLine();
    }
}

Zadacha36 ();
*/

//----------------------------------------------------------------------------------------------------------------------------------------
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha38()
{
    double[] array = new double[6];
    Random rand = new Random();
    double numberMin, numberMax, diff;
    
    FillRandArray(array);
    PrintArray(array);
    FindMinNumber(array);
    FindMaxNumber(array);
    DiffMinMaxNumbers(numberMin, numberMax);
    PrintDiffMaxMinNumbers(diff);

    double[] FillRandArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((rand.NextDouble()*(10 + 10) - 10), 2); // задаем промежуток чисел от -10.00 до 10.00 не включительно
        }
        return array;
    }
    
    void PrintArray (double[] array)
    {
        Console.WriteLine();
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
    }

    double FindMinNumber(double[] array)
    {
        numberMin = array[0];
        for(int i = 1; i < array.Length; i++)
        {
           if (array[i] < numberMin) numberMin = array[i];
        }
        return numberMin;
    }

    double FindMaxNumber(double[] array)
    {
        numberMax = array[0];
        for(int i = 1; i < array.Length; i++)
        {
           if (array[i] > numberMax) numberMax = array[i];
        }
        return numberMin;
    }

    double DiffMinMaxNumbers(double numberMin, double numberMax)
    {
        diff = numberMax - numberMin;
        return diff;
    }

    void PrintDiffMaxMinNumbers(double diff)
    {
        Console.WriteLine($"В сгенерированном нами массиве разница между максимальным и минимальным числом равна {diff}!");
        Console.WriteLine();
    }
}

Zadacha38 ();
