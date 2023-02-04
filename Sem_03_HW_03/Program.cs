// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int getNumber = 0;
int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out getNumber) && getNumber > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Неправильно введено число или введено не число. Попробуйте снова!");
        }
    }
    return getNumber;
}

int number = GetNumber("Введите число:");
for (int i = 1; i <= number; i++)
{
   Console.Write($"{i*i*i} ");
}