// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//я старалась сделать универсальный метод

void Check()
{
    Console.WriteLine("Введите число:");
    string number = Console.ReadLine();
    int length = number.Length;
    for (int i = 0; i < length-1/2; i++)
    {
        if (number[i]==number[length-1])
        {
            length = length - 1;
        }
    }
        if (length == number.Length/2)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
}
    Check();

