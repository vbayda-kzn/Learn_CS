// Домашняя работа по C# - Семинар 1. Байда Владимир

// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Введите первое число: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = Convert.ToDouble(Console.ReadLine());

if (numberA > numberB) Console.WriteLine($"Первое число ({numberA}) больше второго числа ({numberB})");
else Console.WriteLine($"Второе число ({numberB}) больше первого числа ({numberA})");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Введите первое число: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double numberC = Convert.ToDouble(Console.ReadLine());
if (numberA > numberB && numberA > numberC) Console.WriteLine($"Первое число ({numberA}) больше второго ({numberB}) и третьего числа ({numberC})");
else if (numberB > numberA && numberB > numberC) Console.WriteLine($"Второе число ({numberB}) больше первого ({numberA}) и третьего числа ({numberC})");
else Console.WriteLine($"Третье число ({numberC}) больше второго ({numberB}) и первого числа ({numberA})");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine($"Число ({number}) является четным");
else Console.WriteLine($"Число ({number}) является нечетным");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < numberN)
{
    Console.Write(count + ", ");
    count++;
}
Console.Write(numberN);

