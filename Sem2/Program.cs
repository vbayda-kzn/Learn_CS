// Задача 9. Вывести случаное число из отрезка [10, 99] и показывает наибольшую цифру числа

/*Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine(number);

void Zadacha9(int currentNumber )
{
    if (currentNumber / 10 > currentNumber % 10)  Console.WriteLine(currentNumber / 10);
    else if (currentNumber / 10 < currentNumber % 10) Console.WriteLine(currentNumber % 10);
    else Console.WriteLine("цифры числа равны");
}
Zadacha9(number);
*/

// Задача 11. Написать программу которая выводит случаное трехзначное число и удаляет промежуточную цифру.

/*Random rand = new Random();
int number = rand.Next(100,1000);
Console.WriteLine(number);

void Zadacha11(int currentNumber )
{
    int a1 = currentNumber / 100;
    // int a2 = currentNumber % 100 / 10;
    int a3 = currentNumber % 10;
    int result = a1*10 + a3;
    Console.WriteLine(result);
}
Zadacha11(number);
*/

// Задача 11. Черех массив написать программу которая выводит случаное трехзначное число и удаляет промежуточную цифру.

/*Console.WriteLine("введите число: ");
string number = Console.ReadLine();

Console.WriteLine(number);

void Zadacha11(string currentNumber)
{
    Console.Write(" " + currentNumber[0]+currentNumber[2] +" ");
}
Zadacha11(number);
*/


// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.


/*Console.WriteLine("введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1 + ", " + number2);

void Zadacha12(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
    {
        Console.WriteLine("является кратным");
    }
    else
    {
        Console.WriteLine($"не является кратным -  {arg1 % arg2}");
    }
    
}
Zadacha12(number1, number2);
*/

// Задача 14. 

/*Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void Zadacha14(int arg)
{
    if (arg % 7 == 0 && arg % 23 == 0)
    {
        Console.WriteLine("число является кратным 7 и 23");
    }
    else
    {
        Console.WriteLine("число не является кратным 7 и 23");
    }
}
Zadacha14(number);
*/

//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*Console.WriteLine("введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1 + ", " + number2);

void Zadacha12(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
    {
        Console.WriteLine("является кратным");
    }
    else
    {
        Console.WriteLine($"не является кратным -  {arg1 % arg2}");
    }
    
}
Zadacha12(number1, number2);
*/

// Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


Console.WriteLine("введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
void Zadacha16(int arg1, int arg2)
{
    if (arg1 == arg2*arg2 || arg2 == arg1*arg1)
    {
        Console.WriteLine("одно число является квадратом другого");
    }
    else
    {
        Console.WriteLine("одно число не является квадратом другого");
    }
}
Zadacha16(number1, number2);