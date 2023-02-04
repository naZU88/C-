// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int getNumber = 0;
int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out getNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Неправильно введено число или введено не число. Попробуйте снова!");
        }
    }
    return getNumber;
}

int x1 = GetNumber("Введите координату x1");
int y1 = GetNumber("Введите координату y1");
int z1 = GetNumber("Введите координату z1");

int x2 = GetNumber("Введите координату x2");
int y2 = GetNumber("Введите координату y2");
int z2 = GetNumber("Введите координату z2");

double destination = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

Console.WriteLine(destination);


