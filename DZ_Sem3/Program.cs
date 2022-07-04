// Домашняя работа по C# - Семинар 3. Байда Владимир

//--------------------------------------------------------------------------------------------------------------------------
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*Console.WriteLine("введите число: ");
string number = Console.ReadLine();
int numberLength = number.Length;

void Zadacha19(string number)
{
    string result = "";
    for (int i = 0; i <= (number.Length / 2); i++)
    {
        if (number[i] != number[numberLength - i - 1])
        {
            result = " не";
            break;
        } 
    }
    Console.WriteLine($"Число {number}{result} является палиндромом.");
}
Zadacha19(number);
*/


//--------------------------------------------------------------------------------------------------------------------------
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*Console.WriteLine("введите координаты точки А: ");
Console.Write("X: ");
int coordX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int coordY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int coordZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты точки B: ");
Console.Write("X: ");
int coordX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int coordY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int coordZ2 = Convert.ToInt32(Console.ReadLine());

void Zadacha21(int coordX1, int coordY1, int coordZ1, int coordX2, int coordY2, int coordZ2)
{
    Console.WriteLine(
        $"Расстояние между точками А и В: {Math.Sqrt(Math.Pow((coordX2-coordX1),2) + Math.Pow((coordY2-coordY1),2) + Math.Pow((coordZ2-coordZ1),2))}."
    );
}
Zadacha21(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2);
*/

//--------------------------------------------------------------------------------------------------------------------------
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*Console.WriteLine("введите целое натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
void Zadacha23(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}
Zadacha23(number);
*/

//--------------------------------------------------------------------------------------------------------------------------
// Дополнительные задачи.
// Задача 1. Рассчитать значение y при заданном x по формуле ...

/*Console.Write("введите число X: ");
double X = Convert.ToDouble(Console.ReadLine());

void DopZadacha1(double X)
{
    double Y;
    if (X > 0)  Y = Math.Pow(Math.Sin(X), 2);
    else Y = 1 - 2 * Math.Sin(Math.Pow(X, 2));
    Console.WriteLine(Y);
}
DopZadacha1(X);
*/


//--------------------------------------------------------------------------------------------------------------------------
// Задача 2. Дано число N. Определить кратна ли трём сумма всех его цифр.

/*Console.WriteLine("введите целое положительное число: ");
string number = Console.ReadLine();
int numberLength = number.Length;

void DopZadacha2(string number)
{
    int Sum = 0;
    for (int i = 0; i <= (number.Length -1); i++)
    {
        Sum += Convert.ToInt32(Convert.ToString(number[i]));
    } 
    if (Sum % 3 ==0) Console.WriteLine($"Сумма чисел {Sum} кратна трём.");
    else Console.WriteLine($"Сумма чисел {Sum} не кратна трем");
}
DopZadacha2(number);
*/

//--------------------------------------------------------------------------------------------------------------------------
// Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.

/*Console.WriteLine("введите целое положительное число не меньше трёх цифр: ");
string number = Console.ReadLine();
int numberLength = number.Length;
String Result = "не ";
void DopZadacha3(string number)
{
    int X;
    for (int i = 0; i <= (number.Length -1); i++)
    {
        X =  Convert.ToInt32(Convert.ToString(number[i]));
        if (X == 4 || X == 7) 
        {
            Result = "";
            break;
        } 
    }
    Console.WriteLine($"в числе {number} {Result}содержатся цифры 4 или 7.");
}
DopZadacha3(number);
*/


//--------------------------------------------------------------------------------------------------------------------------
// Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.

/*int[] array = new int[10];
void DopZadacha4(int[] array)
{
    Console.WriteLine("Вывод массива через цикл: ");
    for (int i = 0; i <= (array.Length - 1); i++)
    {
        array[i] = i + 1;
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
    Console.WriteLine("Вывод массива без цикла: ");
    Console.Write("[{0}]", string.Join(", ", array));
}
DopZadacha4(array);
*/


//--------------------------------------------------------------------------------------------------------------------------
// Дополнительные задачи повышенно сложности. Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти.
// Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

/*Console.WriteLine("Введите номер четверти, в котороц создадутся 3 случаные точки");
Console.WriteLine("(нумерация четвертей производится против часовой стрелки)");
int Part = Convert.ToInt32(Console.ReadLine());

void DopSuperZadacha1(int Part)
{
    int SignX = 1, SignY = 1;
    if (Part == 2 || Part == 3) SignX = -1;
    if (Part == 3 || Part == 4) SignY = -1;

    Random rand = new Random();
    int numberAX = (rand.Next(1,100))*SignX;
    int numberAY = (rand.Next(1,100))*SignY;
    int numberBX = (rand.Next(1,100))*SignX;
    int numberBY = (rand.Next(1,100))*SignY;
    int numberCX = (rand.Next(1,100))*SignX;
    int numberCY = (rand.Next(1,100))*SignY;
    Console.WriteLine($"Четверть {Part}, созданы точка A({numberAX}:{numberAY}), точка B({numberBX}:{numberBY}), точка C({numberCX}:{numberCY}).");
    double A0 = Math.Sqrt(Math.Pow(numberAX,2) + Math.Pow(numberAY,2));
    double B0 = Math.Sqrt(Math.Pow(numberBX,2) + Math.Pow(numberBY,2));
    double C0 = Math.Sqrt(Math.Pow(numberCX,2) + Math.Pow(numberCY,2));
    double AB = Math.Sqrt(Math.Pow((numberAX - numberBX),2) + Math.Pow((numberAY - numberBY),2));
    double AC = Math.Sqrt(Math.Pow((numberAX - numberCX),2) + Math.Pow((numberAY - numberCY),2));
    double BC = Math.Sqrt(Math.Pow((numberBX - numberCX),2) + Math.Pow((numberBY - numberCY),2));
    double ABC = Math.Round((A0 + AB + BC), 2);
    string MyWay = "0-A-B-C";
    double MinRasst = ABC;

    double ACB = Math.Round((A0 + AC + BC), 2);
    if (ACB < MinRasst)
    {
        MyWay = "0-A-C-B";
        MinRasst = ACB;   
    }

    double BAC = Math.Round((B0 + AB + AC), 2);
    if (BAC < MinRasst)
    {
        MyWay = "0-B-A-C";
        MinRasst = BAC;   
    }

    double BCA = Math.Round((B0 + BC + AC), 2);
    if (BCA < MinRasst)
    {
        MyWay = "0-B-C-А";
        MinRasst = BCA;   
    }

    double CAB = Math.Round((C0 + AC + AB), 2);
    if (CAB < MinRasst)
    {
        MyWay = "0-C-A-B";
        MinRasst = CAB;   
    }

    double CBA = Math.Round((C0 + BC + AB), 2);
    if (CBA < MinRasst)
    {
        MyWay = "0-C-B-A";
        MinRasst = CBA;   
    }

    Console.WriteLine($"0-A-B-C: {ABC}, 0-A-C-B: {ACB}, 0-B-A-C: {BAC}, 0-B-C-A: {BCA}, 0-C-A-B:{CAB}, 0-C-B-A:{CBA}.");
    Console.WriteLine($"Наиболее кратчаший путь - это {MyWay}, расстояние составит значение {Math.Round(MinRasst, 2)}.");
}

DopSuperZadacha1(Part);
*/

//--------------------------------------------------------------------------------------------------------------------------
// Дополнительные задачи повышенно сложности. Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD? 
// Задача 3. Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).

double[] pointA = {-3, 7};
double[] pointB = {-3, 4};
double[] pointC = {-2, 7};
double[] pointD = {-3, 4};
double crossX = 0;
double crossY = 0;
double k_AB = 0;
double k_CD = 0;
double a_AB = 0;
double a_CD = 0;

string Cross = "не ";
int Parallel = 0;

// сначала попробуем определить точку пересечения прямых, построенных 
// на отрезках.
// уравнение прямой: y = k*x + a
// k - тангенс угла с осью х

// если один из отрезков вертикальный (чтоб избежать в дальнешем деления на ноль):
if (pointA[0] == pointB[0])
{
    crossX = pointA[0];
    k_CD = (pointC[1] - pointD[1]) / (pointC[0] - pointD[0]);
    a_CD = pointC[1] - k_CD * pointC[0];
}
else if (pointC[0] == pointD[0])
{
    crossX = pointC[0];
    k_AB = (pointA[1] - pointB[1]) / (pointA[0] - pointB[0]);
    a_AB = pointA[1] - k_AB * pointA[0];
}
// для общих случаев находим тангенсы и коэффициенты а
else
{
    k_AB = (pointA[1]-pointB[1]) / (pointA[0] - pointB[0]);
    k_CD = (pointC[1]-pointD[1]) / (pointC[0] - pointD[0]);
    a_AB = pointA[1] - k_AB * pointA[0];
    a_CD = pointC[1] - k_CD * pointC[0];
    //проверяем на паралельность
    if (k_AB == k_CD)
    {
        Parallel = 1; //если параллельны
        Cross = "не ";
    } 
    else // если не параллельны вычисляем коорднату X точки пересечения прямых
    {
        crossX = (a_CD - a_AB) / (k_AB - k_CD);

    }
}

if (Parallel != 1) // вычисляем координату Y точки пересечения прямых
{
    if ((pointA[0] != pointB[0])) crossY = (k_AB * crossX) + a_AB; 
    else if ((pointC[0] != pointD[0])) crossY = (k_CD * crossX) + a_CD; 
    else Parallel = 1; // добавляем свойство паралельности если оба отрезка вертикальные
}

// теперь определим, прринадлежит ли координата X точки пересечения прямых заданным отрезкам 
if (Parallel == 1) Console.WriteLine($"Отрезки AB и BC {Cross}пересекаются, потому что они паралельны");
else 
{
    if ((Math.Min(pointA[0], pointB[0]) <= crossX) && (Math.Max(pointA[0], pointB[0]) >= crossX))
    {
        if  ((Math.Min(pointC[0], pointD[0]) <= crossX) &&  (Math.Max(pointC[0], pointD[0]) >= crossX))
        {
            Cross = "";
        }
    } 
    Console.WriteLine($"Коорднаты точки пересечения прямых, построеных на заданных отрезках: ({Math.Round(crossX, 2)}:{Math.Round(crossY, 2)}).");
    Console.Write($"Отрезки AB и BC {Cross}пересекаются");
}
// находим четверть где точки отрезки пересекаются
if (Cross == "") 
{
    if (crossX < 0)
    {
        if (crossY < 0) Console.Write(" в четверти 3.");
        else Console.Write(" в четверти 2.");
    }
    else
    {
        if (crossY < 0) Console.Write(" в четверти 4.");
        else Console.Write(" в четверти 1.");
    }
}


