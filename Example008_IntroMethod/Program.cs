// Задача про нахождение большего из 9 чисел.
int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 34, b1 = 21, c1 = 5,
    a2 = 55, b2 = 11, c2 = 100,
    a3 = 76, b3 = 7, c3 = 156;

int maxx = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(maxx);