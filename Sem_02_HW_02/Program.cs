/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int GetNewNumber()
{
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    return number;
}

Console.WriteLine("Введите число:");
int number = GetNewNumber();

if (number > 99 || number < -99)
{
    if (number>999)
    {
       while (number>999)
       {
        number = number/10;
       }
        int digit = number % 10;
        Console.WriteLine($"Третья цифра {digit}");
    }
    else
    {
        if (number<-999)
        {
            while (number<-999)
       {
        number = number/10;
       }
        int digit = number*(-1) % 10;
        Console.WriteLine($"Третья цифра {digit}");
        }
    }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


