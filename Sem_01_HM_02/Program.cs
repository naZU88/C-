

Console.WriteLine("Введите первое число:");
string numberStr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число:");
string numberStr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberStr2);

Console.WriteLine("Введите третье число:");
string numberStr3 = Console.ReadLine();
int number3 = Convert.ToInt32(numberStr3);


if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine($"Число {number1} самое большое");
    }
    else 
    {
        Console.WriteLine($"Число {number3} самое большое");
    }
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine($"Число {number2} самое большое");
    }
    else 
    {
        Console.WriteLine($"Число {number3} самое большое");
    }
}