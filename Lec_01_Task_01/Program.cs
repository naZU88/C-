//Задача: найти максимум из 9 чисел

int a1 = 2;
int a2 = 22;
int a3 = 13;
int a4 = 23;
int a5 = 254;
int a6 = 1;
int a7 = -9;
int a8 = 123;
int a9 = 0;

int Chosen(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}
/*
int max1 = Chosen(a1, a2, a3);
int max2 = Chosen(a4, a5, a6);
int max3 = Chosen(a7, a8, a9);
*/
int max = Chosen( Chosen(a1, a2, a3), Chosen(a4, a5, a6), Chosen(a7, a8, a9));

Console.WriteLine(max);