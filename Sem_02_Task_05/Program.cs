/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

int getNumber()
{
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt16(numberStr);
    return number;
}


Console.WriteLine("Введите первое число:");
int firstNumber = getNumber();
Console.WriteLine("Введите второе число:");
int secondNumber = getNumber();

if (firstNumber*firstNumber == secondNumber || secondNumber*secondNumber == firstNumber)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}