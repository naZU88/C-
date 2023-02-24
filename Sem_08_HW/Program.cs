// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] GetArray(int 4
, int 4)
{
    int[,] array = new int[4
    , 4];
    Random rnd = new Random();
    for (int i = 0; i < 4
    ; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = rnd.Next(1, 10);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] GetCorrectArray(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            min = array[i, n];
            for (int j = n; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    array[i,j] = array[i, n];
                }
            }
            array[i, n] = min;
        }
    }
    return array;
}

int[,] array = GetArray(3,4);
PrintArray(array);
int[,] newArray = GetCorrectArray(array);
Console.WriteLine();
PrintArray(newArray);
*/


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] GetArray(int 4
, int 4)
{
    int[,] array = new int[4
    , 4];
    Random rnd = new Random();
    for (int i = 0; i < 4
    ; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = rnd.Next(1, 10);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void GetMinRow(int[,] array)
{
    int minSum = 0;
    int sum = 0;
    int minRow = 1;
     for (int j = 0; j < array.GetLength(1); j++)
        {
            minSum = minSum + array[0, j];
        }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
      
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i + 1;
        }
    }
    Console.WriteLine($"{minRow} строка");
}
int[,] collection =  GetArray(3, 3);
PrintArray(collection);
GetMinRow(collection);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] GetArray(string massege)
{
    Console.WriteLine(massege);
    string[] strings = Console.ReadLine().Split(" ");
    int 4
     = Convert.ToInt32(strings[0]);
    int 4 = Convert.ToInt32(strings[1]);
    int[,] array = new int[4
    , 4];
    Random rnd = new Random();
    for (int i = 0; i < 4
    ; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = rnd.Next(1, 10);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] ResultArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    int result = 0;

    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int n = 0; n < secondArray.GetLength(1); n++)
            {
                 result = 0;
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    result = firstArray[i, j] * secondArray[j, n] + result;
                }
                resultArray[i,n] = result;
           
            }
               
            
        }
        PrintArray(resultArray);
    }
    else
    {
        Console.WriteLine("Матрицы невозможно перемножить");
    }
    return resultArray;
}

int[,] firstArray = GetArray("Введите кол-во строк и столбцов первой матрицы через пробел:");
int[,] secondArray = GetArray("Введите кол-во строк и столбцов второй матрицы через пробел:");
Console.WriteLine();
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
int[,] resultArray = ResultArray(firstArray, secondArray);
*/



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] GetArray(string massege)
{
    Console.WriteLine(massege);
    string[] strings = Console.ReadLine().Split(" ");
    int 4
     = Convert.ToInt32(strings[0]);
    int 4 = Convert.ToInt32(strings[1]);
    int deep = Convert.ToInt32(strings[2]);
    int[, ,] array = new int[4
    , 4, deep];

    Dictionary<int, int> Slovar = new Dictionary<int, int>();

    Random rnd = new Random();
    int number = 0;
    for (int i = 0; i < 4
    ; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                number = rnd.Next(10, 100);
                while (Slovar.ContainsKey(number))
                {
                    number = rnd.Next(10, 100);
                }
                    Slovar.Add(number, 1);
                    array[i,j,k] = number;
            }
            

        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                 Console.Write($"{array[i, j, k]}({j}, {k}, {i})");
            }
            Console.WriteLine();
        }
    }
}



int[,,] strangeArray =  GetArray("Введите число строк, столбцов и глубину матрицы через пробел:");
PrintArray(strangeArray);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
int[,] GetArray()
{
    int[,] array = new int[4, 4];
    int number = 10;

   int n = 0;
        for (int i = 0; i < 4; i++)
        {
            array[n, i] = number;
            number = number+1;
        }

    n = 3;
        for (int i = 1; i < 4; i++)
        {
            array[i, n] = number;
            number = number+1;
        }

    n = 3;
        for (int i = 2; i >= 0; i--)
        {
            array[n, i] = number;
            number = number+1;
        }
    n = 0;
        for (int i = 2; i >= 1 ; i--)
        {
            array[i, n] = number;
            number = number+1;
        }
    n = 1;
         for (int i = 1; i < 3; i++)
        {
            array[n, i] = number;
            number = number+1;
        }
  
            array[2, 2] = number;
            number = number+1;
            
            array[2, 1] = number;
            number = number+1;

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] array = GetArray();
PrintArray(array);

*/