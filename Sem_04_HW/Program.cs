// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int getArray = 0;
int GetArray(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out getArray))
        {
            break;
        }
        else
        {
            Console.WriteLine("Неправильно введено число или введено не число. Попробуйте снова!");
        }
    }
    return getArray;
}

int Array1 = GetArray("Введите первое число:");
int Array2 = GetArray("Введите второе число:");
double result = Math.Pow(Array1, Array2);
   Console.Write(result);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int getArray = 0;
int GetArray(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out getArray))
        {
            break;
        }
        else
        {
            Console.WriteLine("Неправильно введено число или введено не число. Попробуйте снова!");
        }
    }
    return Math.Abs(getArray);
}

void Counting(int Array)
{
    int sum = 0;
    while (Array>0)
    { 
        sum = sum + Array%10;
        Array = Array/10;
    }
    Console.WriteLine(sum);
}
int Array = GetArray("Введите число:");
Counting(Array);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
void GetArray(int[] array)
{
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Введите новый элемент массива:");
    int newNumber = Convert.ToInt32(Console.ReadLine());
    array[i] = newNumber;
}
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < 7; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[7]}]");
}
int[] array = new int[8];
GetArray(array);
PrintArray(array);
*/