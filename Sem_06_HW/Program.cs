// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел:");
string numbers = (Console.ReadLine());
string[] gotNumbers = numbers.Split(" ");
int[] gN = new int[gotNumbers.Length];
for (int i = 0; i < gotNumbers.Length; i++)
{
    gN[i] = Convert.ToInt32(gotNumbers[i]);
}

int count = 0;
for (int i = 0; i < gN.Length; i++)
{
    if (gN[i] > 0)
    {
        count = count+1;
    }
}
Console.WriteLine(count);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1:");
int numberK1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2:");
int numberK2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1:");
int numberB1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2:");
int numberB2=Convert.ToInt32(Console.ReadLine());

double numberX = ((numberB2 - numberB1)/(numberK1 - numberK2));
double numberY = numberX*numberK1 + numberB1;
Console.WriteLine($"({numberX};{numberY})");
