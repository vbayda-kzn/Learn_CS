// Первая задача семинара 1. Квадрат числа.

//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{number} в квадрате равно {Math.Pow(number, 2)}");

// Вторая задача семинара 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

//Console.WriteLine("Введите число 1: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число 2: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1 == Math.Pow(number2, 2))
//{
//  Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");  
//}
//else
//{
//  Console.WriteLine($"Первое число {number1} не является квадратом второго числа {number2}");    
//}

// Третья задача семинара 1. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//Console.Write("Введите номер дня недели, пожалуйста: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number == 1) Console.Write("Это Понедельник");
//else if (number == 2) Console.Write("Вроде вторник");
//else if (number == 3) Console.Write("Скорее всего среда");
//else if (number == 4) Console.Write("Это точно четверг");
//else if (number == 5) Console.Write("Это же пятница))");
//else if (number == 6) Console.Write("Конечно же суббота");
//else if (number == 7) Console.Write("Воскресенье");
//else Console.Write("Введено что-то неправильное");

//Четвертая задача семинара 1. Написать программу функции возведения числа в квадрат
//int currentNumber = 6;
//void OurPower(int currentNumber)
//{
//    Console.WriteLine(currentNumber * currentNumber);
//}
//OurPower(currentNumber);

//Пятая задача семинара 1. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int count = -number;
while (count <= (number))
{
    Console.Write(count + ", ");
    count++;
}

