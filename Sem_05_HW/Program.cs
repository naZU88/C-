// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
void newArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void printArray(int[] array)
{
    int position = 0;
    int count = array.Length;
    while (position<count)
    {
     Console.Write($"{array[position]} ");
     position++;

    }
}

void printCounts(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
        {
            count = count+1;
        }
    }
    Console.WriteLine(count);
}

int[] collection = new int[4];
newArray(collection);
printArray(collection);
printCounts(collection);
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
void newArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
}

void printArray(int[] array)
{
    int position = 0;
    int count = array.Length;
    while (position<count)
    {
     Console.Write($"{array[position]} ");
     position++;

    }
}

void printSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0 )
        {
            sum = array[i] + sum;
        }
    }
    Console.WriteLine($"-> {sum}");
}

int[] collection = new int[4];
newArray(collection);
printArray(collection);
printSum(collection);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
void newArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
}

void printArray(int[] array)
{
    int position = 0;
    int count = array.Length;
    while (position<count)
    {
     Console.Write($"{array[position]} ");
     position++;

    }
}


(int, int) GetMaxMin(int[] array)
{
    int max =0;
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        if (array[i]<min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"-> Максимальное и минимальное числа: {max} и {min} ");
    return (max, min);
}

void PrintDiff(int max, int min)
{
    int diff = max-min;
    Console.WriteLine($"-> Разница равна {diff} ");
}

int[] collection = new int[5];
newArray(collection);
printArray(collection);
(int max, int min) = GetMaxMin(collection);
PrintDiff(max, min);
*/