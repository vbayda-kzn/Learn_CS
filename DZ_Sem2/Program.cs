// Домашняя работа по C# - Семинар 2. Байда Владимир

//--------------------------------------------------------------------------------------------------------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*Console.WriteLine("введите число: ");
string number = Console.ReadLine();
int numberLength = number.Length;
if (numberLength < 3) Console.WriteLine($"третьей цифры в числе {number} нет."); 
else Console.WriteLine($"третья цифра в числе {number} это {number[2]}."); 
*/


//--------------------------------------------------------------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*string[] week = {"Нет", "Нет", "Нет", "Нет", "Нет", "Да", "Да"};
Console.WriteLine("введите цифру, обозначающую день недели (1 - 7)");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Является ли день недели с порядковым номером {number} выходным днем? {week[number-1]}.");
*/


//--------------------------------------------------------------------------------------------------------------------------
// Доп.Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

/*Console.WriteLine("введите длину первой стороны треугольника");
int storonaA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите длину второй стороны треугольника");
int storonaB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите длину третьей стороны треугольника");
int storonaC = Convert.ToInt32(Console.ReadLine());

void Treugolnik(int arg1, int arg2, int arg3)
{
    if (arg1 == arg2 || arg1 == arg2 || arg2 == arg3) Console.WriteLine("Наш треугольник равнобедренный.");
    else Console.WriteLine("Наш треугольник не равнобедренный.");
}

Treugolnik(storonaA, storonaB, storonaC);
*/

// Доп.Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.

/*Console.WriteLine("введите год рождения: ");
int yearB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите месяц рождения: ");
int monthB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите день месяца рождения: ");
int dayB = Convert.ToInt32(Console.ReadLine());
int yearMoment = 2022, monthMoment = 7, dayMoment = 1;

void VozrastNa01072022(int argY, int argM, int argD)
{
    if (monthMoment > argM) Console.WriteLine($"Возраст человека - {yearMoment - argY} лет (года).");
    else if (monthMoment < argM) Console.WriteLine($"Возраст человека - {yearMoment - argY - 1} лет (года).");
    else
    {
        if (dayMoment >= argD) Console.WriteLine($"Возраст человека - {yearMoment - argY} лет (года).");
        else Console.WriteLine($"Возраст человека - {yearMoment - argY - 1} лет (года).");
    }
}

VozrastNa01072022(yearB, monthB, dayB);
*/


// Доп.Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
// Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
// Определить размер депозита через n месяцев.

/*double Schet = 1000;
Console.WriteLine("введите количество месяцев, на которое размещается депозит: ");
int numberMonth = Convert.ToInt32(Console.ReadLine());

void Depozit(int arg)
{
    double result = Schet;
    int count = 0;
    while (count < arg)
    {
        result = result + result * 0.015;
        count++;
    }
    Console.WriteLine($"Если положить {Schet} рублей, то за {numberMonth} месяца(ев) получим {result} рублей");
}

Depozit(numberMonth);
*/

// Доп.Задача 4. Дано натуральное число, в котором все цифры различны. 
// Определить, какая цифра расположена в нем левее: максимальная или минимальная.


Console.WriteLine("введите любое натуральное число больше 9, все цифры в котором различны: ");
string chislo = Console.ReadLine();

void LevoPravo(string number)
{
    int length = number.Length;
    int count = 0, min = 0, max = 0;
    while (count < (length))
    {
        if (number[count] > number[max]) max = count;
        if (number[count] < number[min]) min = count;
        count++;
    }
    if (max < min) Console.WriteLine("Максимальная цифра в числе находится левее минимального");
    else Console.WriteLine("Минимальная цифра в числе находится левее максимального");
}

LevoPravo(chislo);




