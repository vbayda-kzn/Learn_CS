// Домашняя работа по C# - Семинар 1. Дополнительные задачи.Байда Владимир

//--------------------------------------------------------------------------------------------------------------------------
// Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.

/*Console.Write("Введите целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 1;
void Ones (int count, int numberN)
{
    while (count <= numberN)
    {
        Console.Write(1 + ", ");
    
        count++;
    }
}
Ones(count, numberN);
Console.Write("\b\b ");
*/

//--------------------------------------------------------------------------------------------------------------------------
//Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.

/*Console.Write("Введите первое число: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число, большее чем первое: ");
double numberB = Convert.ToDouble(Console.ReadLine());
void Skolko_Raz(double numberA, double numberB)
{
    Console.WriteLine($"Число {numberA} поместится в числе {numberB} целых {Math.Floor(numberB / numberA)} раз(a)");
}
Skolko_Raz(numberA, numberB);
*/

//--------------------------------------------------------------------------------------------------------------------------
//Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.

/*Console.Write("Введите рост первого спортсмена: ");
int rost1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите рост второго спортсмена (должен отличаться от первого): ");
int rost2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите рост третьего спортсмена (должен отличаться от первого и второго): ");
int rost3 = Convert.ToInt32(Console.ReadLine());
int max_rost, mid_rost, min_rost;
void Range_sport(int rost1, int rost2, int rost3)
{
    if (rost1 > rost2 && rost1 > rost3) 
    {
        max_rost = rost1;
        if (rost2 > rost3) 
        {
            mid_rost = rost2;
            min_rost = rost3;
        }
        else
        {
            mid_rost = rost3;
            min_rost = rost2;
        }
    }
    else if (rost2 > rost1 && rost2 > rost3) 
    {
        max_rost = rost2;
        if (rost1 > rost3) 
        {
            mid_rost = rost1;
            min_rost = rost3;
        }
        else
        {
            mid_rost = rost3;
            min_rost = rost1;
        }
    }
    else
    {
        max_rost = rost3;
        if (rost2 > rost1) 
        {
            mid_rost = rost2;
            min_rost = rost1;
        }
        else
        {
            mid_rost = rost1;
            min_rost = rost2;
        }
    }
    Console.Write($"{max_rost} - {mid_rost} - {min_rost}");
}
Range_sport(rost1, rost2, rost3);
*/

//--------------------------------------------------------------------------------------------------------------------------
//Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
//N = 72334 -> 20:5:34 
Console.Write("Введите число секунд: ");
int seconds = Convert.ToInt32(Console.ReadLine());
void Convert_Time(int seconds)
{
    Console.WriteLine($"{seconds / 3600}:{seconds % 3600 / 60}:{seconds % 3600 % 60}");
}
Convert_Time(seconds);

