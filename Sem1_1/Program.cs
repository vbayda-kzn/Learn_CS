// Первая задача семинара 1. Квадрат числа.

//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{number} в квадрате равно {Math.Pow(number, 2)}");

// Вторая задача семинара 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == Math.Pow(number2, 2))
{
  Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");  
}
else
{
  Console.WriteLine($"Первое число {number1} не является квадратом второго числа {number2}");    
}

//Console.WriteLine($"{number} в квадрате равно {Math.Pow(number, 2)}");