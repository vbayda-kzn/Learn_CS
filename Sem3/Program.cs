// Семинар по С# 3. 

// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*Console.WriteLine("введите X: ");
int cX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y: ");
int cY = Convert.ToInt32(Console.ReadLine());

void Zadacha17(int cX, int cY)
{
    if (cX > 0 && cY > 0) Console.WriteLine("Координата в секторе 1");
    else if (cX < 0 && cY > 0) Console.WriteLine("Координата в секторе 2");
    else if (cX > 0 && cY < 0) Console.WriteLine("Координата в секторе 3");
    else Console.WriteLine("Координата в секторе 4");
}
Zadacha17(cX, cY);
*/


// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


/*Console.WriteLine("введите номер четверти: ");
int Chetvert = Convert.ToInt32(Console.ReadLine());

void Zadacha18(int Chetvert)
{
    if (Chetvert == 1) Console.WriteLine("X от 0 до бесконечности, Y от 0 тоже до бесконечности");
    else if (Chetvert == 2) Console.WriteLine("X от минус бесконечности до 0, Y от 0 до бесконечности");
    else if (Chetvert == 3) Console.WriteLine("X от минус бесконечности до 0, Y от минус бесконечности до 0");
    else Console.WriteLine("X от 0 до  бесконечности, Y от минус бесконечности до 0");
}
Zadacha18(Chetvert);
*/

// Задача 21. Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D

/*Console.WriteLine("введите X1: ");
int cX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y1: ");
int cY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите X2: ");
int cX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y2: ");
int cY2 = Convert.ToInt32(Console.ReadLine());

void Zadacha21(int cX1, int cY1, int cX2, int cY2)
{
    Console.WriteLine(Math.Sqrt((cY2-cY1)*(cY2-cY1) + (cX2-cX1)*(cX2-cX1)));
}
Zadacha21(cX1, cY1, cX2, cY2);
*/

// Задача 22.  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("введите целое натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
void Zadacha22(int number)
{
    while (count <= number)
    {
        int count = 1;
        Console.WriteLine(count*count);
        count++;
    }
}
Zadacha22(number);
