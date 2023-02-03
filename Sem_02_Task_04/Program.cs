/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да
*/

int getNumber()
{
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt16(numberStr);
    return number;
}

int Division(int number1, int number2)
{
    int division = number1 % number2;
    return division;
}

Console.WriteLine("Введите число:");
int number = getNumber();
int division1 = Division(number, 7);
int division2 = Division(number, 23);

if (division1 == 0 && division2 == 0)
{
   
        Console.WriteLine("Данное число кратно одновременно 7 и 23");
}
else 
{
    Console.WriteLine("Данное число не кратно 7 и 23 или кратно только одному из чисел");
}