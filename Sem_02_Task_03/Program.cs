/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
int getNumber()
{
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt16(numberStr);
    return number;
}

int Division(int Number1, int Number2)
{
    int division = Number1 % Number2;
    return division;
}

Console.WriteLine("Введите первое число:");
int firstNumber = getNumber();
Console.WriteLine("Введите второе число:");
int secondNumber = getNumber();
int division = Division(firstNumber, secondNumber);

if (division == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine($"Второе число не кратно первому и остаток от деления равен {division}");
}