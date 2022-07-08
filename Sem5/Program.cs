// 4-й семинар по С#.

//Задача 31

/*void Zadacha31()
{    
    int[] array = new int[12];
    Random rand = new Random();
    int sumPositive = 0;
    int sumNegative = 0;
    
    FillRandArray(array);
    
    Console.WriteLine("Выводим исходный массив:");
    PrintRandArray(array);
    
    SortRandArray(array);
    
    Console.WriteLine("Выводим суммы положительных и отрицательных числел в массиве:");
    PrintSumPlusMinus(sumPositive, sumNegative);

    int[] FillRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-9, 10);
        }
        return array;
    }

    int SumPositive(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) sumPositive += array[i];
        }
        return sumPositiv;
    }

     int SumNegative(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) sumNegative += array[i];
        }
        return sumNegative;
    }

    void PrintRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
    }
    
    void PrintSumPlusMinus(int c)
    {
        Console.WriteLine($"{SumNegative(array)} \t {SumNegative(array)}");
    }
}

Zadacha31();
*/

//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.

/*void Zadacha32()
{    
    int[] array = new int[12];
    Random rand = new Random();
    
    
    FillRandArray(array);
    
    Console.WriteLine("Выводим исходный массив:");
    PrintRandArray(array);
    
    ModifyRandArray(array);
    
    Console.WriteLine("Выводим измененный массив:");
    PrintRandArray(array);

    int[] FillRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-9, 10);
        }
        return array;
    }

    int[] ModifyRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] *=(-1);
        }
        return array;
    }

     
    void PrintRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
    }
}

Zadacha32();
*/

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*void Zadacha33()
{    
    int[] array = new int[12];
    Random rand = new Random();
    int number;
    string result = "не ";
    FillRandArray(array);
    PrintRandArray(array);
    FindMyNumber(array, InputNumber());
    
    int[] FillRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-9, 10);
        }
        Console.WriteLine("Выводим исходный массив:");
        return array;
    }
    int InputNumber()
    {
        Console.WriteLine("Введите свое число: ");
        number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    void FindMyNumber(int[] array, int number)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            if (number  == array[i]) result = "";
        }
        Console.WriteLine($"число {number} {result} присутствует в массиве.");
    }
    void PrintRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
    }
}
Zadacha33();

*/

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

/*void Zadacha35()
{
    int[] array = new int[10];
    Random rand = new Random();
    int number;
    int sum = 0;
    
    FillRandArray(array);
    PrintRandArray(array);
    int[] otrezok = {10, 99};
    Finder(array, otrezok);

    int[] FillRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-999, 1000);
        }
        return array;
    }
    
    void PrintRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
    }

    void Finder(int[] array, int[] otrezok)
    {
        int sum = 0;
        int start = otrezok[0];
        int finish = otrezok[1];
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] <= finish) & (array[i] >= start))
            {
                sum++;
            }
        }
        Console.WriteLine($"в заданный отрезок чисел попадает {sum} чисел");
    }
}
Zadacha35();
*/

// Задача 39: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


void Zadacha39()
{
    int[] array = new int[10];
    int[] newArray = new int[array.Length / 2];
    Random rand = new Random();
    int number;

    FillRandArray(array);
    PrintRandArray(array);
    
    Modify(array, newArray);
    PrintRandArray(newArray);

    int[] FillRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-9, 10);
        }
        return array;
    }
        void PrintRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
    }
    int[] Modify(int[] array, int[] newArray)
    {
        for (int i = 0; i < (array.Length / 2); i++)
        {
            {
                newArray[i] = array[i] * array[array.Length - 1 - i];
            }
        }
        return newArray;
    }
}
Zadacha39();


