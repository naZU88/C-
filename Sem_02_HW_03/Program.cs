/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNewDigit()
{
    string digitStr = Console.ReadLine();
    int digit = Convert.ToInt32(digitStr);
    return digit;
}
Console.WriteLine("Введите число:");
int digit = GetNewDigit();
if (digit == 6 || digit == 7)
{
    Console.WriteLine("Указанный день является выходным");
}
else
{
    Console.WriteLine("Указанный день не является выходным");
}

