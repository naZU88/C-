// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
int N = 0;
int GetNumber(string text)
{
    while (true)
    {
        Console.WriteLine(text);
        if(int.TryParse(Console.ReadLine(), out N) && N>0)
        {
            break;
        }
        else
        {
             Console.WriteLine("Неправильно введено число или введено не число");
        }
    }
    return N;
}

string GetAllNumbers(int N)
{
    if (N>0)
    {
        return $"{N} " + GetAllNumbers(N-1);
    }
    else return String.Empty;
}

int Number = GetNumber("Введите натуральное число:");
Console.WriteLine(GetAllNumbers(N));
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int n = 0;
int GetNumber(string text)
{
    while (true)
    {
        Console.WriteLine(text);
        if(int.TryParse(Console.ReadLine(), out n) && n>0)
        {
            break;
        }
        else
        {
             Console.WriteLine("Неправильно введено число или введено не число");
        }
    }
    return n;
}


string GetSumOfNumbers(int M, int N, int sum)
{
    if (M<N)
    {
        M = M+1;
        sum = sum + M;
        return GetSumOfNumbers(M, N, sum);
    }
    else return $"{sum}";
}

int numberOne = GetNumber("Введите первое натуральное число:");
int numberTwo = GetNumber("Введите второе натуральное число:");
Console.WriteLine();
Console.WriteLine(GetSumOfNumbers(numberOne, numberTwo, numberOne));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


/*
static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }else if (n == 0)
            {
                return Ack(m - 1, 1);
            }else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
 
        }
 
Console.WriteLine(Ack(2, 3)); 
*/
 
