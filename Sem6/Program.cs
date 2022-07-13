// Семинар 6 по С#.

//Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*void Zadacha39()
{   
    int[] array = new int[10];
    Random rand = new Random();
    FillArray(array, 1, 10);
    PrintArray(array);
    ReverseArray(array);
    PrintArray(array);


    int[] FillArray(int[] array, int startNumber, int finishNumber)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(startNumber, finishNumber);
        }
        return array;
    }
    int[] PrintArray(int[] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        return array;
    }

    int[] ReverseArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]);
        }
        return array;
    }
}
Zadacha39 ();
*/

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины.

/*void Zadacha40()
{   
    IsTriangle(InputNumberA(), InputNumberB(), InputNumberC());

    int InputNumberA()
    {
        Console.WriteLine("Введите первое число: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        return numberA;
    }

    int InputNumberB()
    {
        Console.WriteLine("Введите второе число: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        return numberB;
    }
    
    int InputNumberC()
    {
        Console.WriteLine("Введите третье число: ");
        int numberС = Convert.ToInt32(Console.ReadLine());
        return numberС;
    }

    void IsTriangle(int numberA, int numberB, int numberC)
    {
        if (numberA + numberB > numberC && numberB + numberC > numberA && numberA + numberC > numberB)
        {
            Console.WriteLine($"треугольник со сторонами {numberA}, {numberB}, {numberC} существует!");
        }
        else
        {
              Console.WriteLine($"треугольник со сторонами {numberA}, {numberB}, {numberC} не существует!");
        }

    }
}   

Zadacha40 ();
*/


//Задача 42: Напишите программу, которая будет преобразовывать десятичные цифры в двоичные

/*void Zadacha42()
{   
    Format(InputNumber());

    int InputNumber()
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

   
    void Format(int number)
    {
        int result = 0;
        int bias = 1;
        while (number >0)
        {
            result += number% 2 * bias;
            bias *=10;
            number /= 2; 
        }
        Console.WriteLine(result);
    }
}   

Zadacha42 ();
*/


//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


/*void Zadacha44()
{   
    Fibo(InputNumber());

    int InputNumber()
    {
        Console.WriteLine("Введите число N: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
   
    void Fibo(int number)
    {
        int numberFirst = 0;
         int numberSecond = 1;
         int i;
        for (i =0; i < number; i++)
        {
            Console.Write(numberFirst + "\t");
            int temp = numberSecond;
            
            numberSecond = numberFirst + numberSecond;
            numberFirst = temp;
        }
        
    }
}   

Zadacha44 ();

*/

//Задача 45: Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void Zadacha45()
{   
    int[] array = new int[10];
    Random rand = new Random();
    FillArray(array, 1, 10);
    PrintArray(array);
    DoubleArray(array);
    PrintArray(DoubleArray(array));


    int[] FillArray(int[] array, int startNumber, int finishNumber)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(startNumber, finishNumber);
        }
        return array;
    }
    int[] PrintArray(int[] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        return array;
    }

    int[] DoubleArray(int[] array)
    {
        int[] newArray = new int[array.Length];
        
        
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        return newArray;
    }
}
Zadacha45 ();

