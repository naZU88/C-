Console.WriteLine("Введите число №1:");

string numberStr1 = Console.ReadLine();

Console.WriteLine("Введите число №2:");

string numberStr2 = Console.ReadLine();

int a = Convert.ToInt32(numberStr1);

int b = Convert.ToInt32(numberStr2);

int result = b * b;

if (result == a)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}

