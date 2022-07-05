// Семинар 4
// Задача 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
/*Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел от 1 до {number} равна {FindSum(number)}");
int FindSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
*/


// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

/*Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {number}  {Numbers_K(number)} цифр(ы)");

int Numbers_K(int number)
{
    int count;
    for (count = 1; number / 10 > 0; count++)
    {
        number = number / 10;
    }
    return count;
}
*/

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"произведение чисел от 1 до {number} равно {FindFac(number)}");

int FindFac(int number)
{
    int fac = 1;
    for (int i = 1; i <= number; i++)
    {
        fac *= i;
    }
    return fac;
}
*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]


void Zadacha30()
{
    int[] array = new int[8];
    Random rand = new Random();
    
    int[] Fill_Zeros_Ones(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0,2);
        }
        return array;
    }
    void PrintArray(int[] array)
    {
        int j;
        for (j = 0; j < array.Length; j++)
        Console.Write(array[j]+ " ");
    }
    Fill_Zeros_Ones(array);
    PrintArray(array);
}

Zadacha30();