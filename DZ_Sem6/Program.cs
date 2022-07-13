// ДЗ по семинару 6. Байда Владимир.
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int M = 10; // количество чисел котороые мы будем вводить.
Console.WriteLine($"Введенно {M} чисел, из них {CountPositiveNumbersInArray(CreateArray(M))} - больше нуля.");

int[] CreateArray(int M)
{
    int[] arrayNumbers = new int[M];
    for (int i=0; i < M; i++)
    { 
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arrayNumbers[i] = number;
    }
    return arrayNumbers;
}

int CountPositiveNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] > 0) count++;
    }
    return count;
}
*/


//----------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 43.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

/*Console.WriteLine("Введите значение параметра b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение параметра k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение параметра b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение параметра k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

LineIntersection(b1, k1, b2, k2);

void LineIntersection(double b1, double k1, double b2, double k2)
{
    if (b1 != b2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = Math.Round((k1 * x + b1), 2);
        x = Math.Round(x, 2);
        Console.WriteLine($"Точка пересечения прямых, заданных уравнениями y = {k1}*x + {b1} и y = {k2}x + {b2}");
        Console.WriteLine($"имеет координаты {x}:{y}");
    } 
    else 
    {
        Console.WriteLine($"Прямые, заданные уравнениями y = {k1}*x + {b1} и y = {k2}*x + {b2}");
        Console.WriteLine($"не пересекаются, т.к. они паралельны.");
    }
}
*/


