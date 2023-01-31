Console.WriteLine("Введите первое число:");
string numberStr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число:");
string numberStr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberStr2);

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} > числа {number2}");
}
if (number1 < number2)
{
    Console.WriteLine($"Число {number2} > числа {number1}");
}
if (number1 == number2)
{
    Console.WriteLine($"Числа {number2} и {number1} равны");
}
