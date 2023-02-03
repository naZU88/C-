/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int GetNewNumber()
{
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    return number;
}
Console.WriteLine("Введите трехзначное число:");
int number = GetNewNumber();
if (number > 0)
{
    int firstResult = number % 100;
    int secondResult = firstResult / 10;
    Console.WriteLine($"Вторая цифра числа {number} {secondResult}");
}
else
{
    int firstResult = number % 100;
    int secondResult = firstResult * (-1) / 10;
    Console.WriteLine($"Вторая цифра числа {number} {secondResult}");
}


