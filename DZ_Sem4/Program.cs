// Домашняя работа по C# - Семинар 3. Байда Владимир

//--------------------------------------------------------------------------------------------------------------------------
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*void Zadacha25 ()
{
    Console.Write("Введите число А: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: "); 
    int numberB = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"Если мы случайно число {numberA} возведем в степень {numberB}, то получим {myPow(numberA, numberB)}!");

    int myPow (int numberA, int numberB)
    {
        return Convert.ToInt32(Math.Pow(numberA, numberB));
    }
}
Zadacha25();
*/


//--------------------------------------------------------------------------------------------------------------------------
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*void Zadacha27 ()
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine();
    
    Console.WriteLine($"Сумма цифр в числе {number} равна {SumNumbers(number)}!");

    int SumNumbers (string number)
    {
        int sum = 0;    
        for (int i = 0; i < number.Length; i++)
        {
            sum += Convert.ToInt32(Convert.ToString((number[i])));
        }
        return sum;
    }
}
Zadacha27();
*/

//--------------------------------------------------------------------------------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void Zadacha29()
{
    int[] array = new int[8];
    Random rand = new Random();
    
    FillRandArray(array);
    
    Console.WriteLine("Выводим исходный массив:");
    PrintRandArray(array);
    
    SortRandArray(array);
    
    Console.WriteLine("Выводим отсортированный по модулю массив:");
    PrintRandArray(array);

    int[] FillRandArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-99, 100);
        }
        return array;
    }

    int[] SortRandArray(int[] array)
    {
        int temp;
        int i;
        int j;
        for (i = 0; i < array.Length - 1; i++)
        {

            for (j = 0; j < array.Length -1 - i; j++)
            {
                if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
                {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
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

Zadacha29();
