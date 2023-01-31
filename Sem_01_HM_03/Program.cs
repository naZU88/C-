
Console.WriteLine("Введите число:");
string numberStr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);

if (number1 % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}
