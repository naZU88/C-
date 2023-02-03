/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int NewRandomDigit(int leftBound, int rightBound)
{
    int result = 0;
    Random rndDigit = new Random();
    result = rndDigit.Next(leftBound, rightBound);
    return result;
}

int GetNewDigit(int result)
{
    int firstNumber = result / 100;
    int secondNumber = result % 10;
    int sumNumber = firstNumber*10 + secondNumber;
    return sumNumber;
}
int number = NewRandomDigit(100, 999);
Console.WriteLine($"Промежуточное число - {number}");
int result = GetNewDigit(number);

Console.WriteLine($"Получившееся число - {result}");


