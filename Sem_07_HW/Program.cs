// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.NextDouble();
            array[i,j] = Math.Round(array[i,j], 1);
            
        }
    }
    return array;
}

void PrintArray(double[,] array, double m, double n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(m, n);
PrintArray(array, m, n);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// пользователь вводит индексы 10, 10 - такого элемента нет.
// пользователь вводите индексы 0, 2 - выводим элеменет 7
/*
int[,] GetArray()
{
    int[,] array = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i,j] = rnd.Next(1,10);
            
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray();
PrintArray(array);

Console.WriteLine("Введите позицию элемента через запятую:");
string numbers = Console.ReadLine();
string[] strings = numbers.Split(",");
int m = Convert.ToInt32(strings[0]);
int n = Convert.ToInt32(strings[1]);


if (m>0 && m<=3 && n>0 && n<=4) 
{
    Console.WriteLine(array[m-1,n-1]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray()
{
    int[,] array = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i,j] = rnd.Next(1,10);
            
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
}

void GetMedResult(int[,] array)
{

    for (int i = 0; i <= 3; i++)
    {
        Double sum = array[0,i] + array[1,i] + array[2,i];
        Double result = sum/3;
        result = Math.Round(result, 1);
        Console.Write($"{result} ");
    }
}

int[,] array = GetArray();
PrintArray(array);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: ");
GetMedResult(array);

