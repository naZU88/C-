//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int GetNumber(string message)
{
int resultNumber = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
{
break;
}
else
{
Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
}
}

return resultNumber;
}

int GetQuarter(int x, int y)
{
if(x > 0 && y > 0)
return 1;
else if(x < 0 && y > 0)
return 2;
else if(x < 0 && y < 0)
return 3;
else
return 4;
}

int x = GetNumber("Введите координату Х, которая не равна 0:");
int y = GetNumber("Введите координату Y, которая не равна 0:");
int quarter = GetQuarter(x,y);

Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти");
*/



//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
int getNumber = 0;
int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out getNumber) && getNumber > 0 && getNumber < 5)
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


int number = GetNumber("Введите число:");
if (number == 1)
    Console.WriteLine("х[0, +бск), y[0, +бск)");
else if (number == 2)
    Console.WriteLine("х[0, -бск), y[0, +бск)");
else if (number == 3)
    Console.WriteLine("х[0], y(-бск, +бск)");
else if (number == 4)
    Console.WriteLine("х[0, +бск), y[0]");

*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
/*
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

int x2 = GetNumber("Введите координату x2");
int y2 = GetNumber("Введите координату y2");


double destination = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));

Console.WriteLine(destination);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

/*
int getNumber = 0;
int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out getNumber) && getNumber > 0)
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

int number = GetNumber("Введите число:");
for (int i = 1; i <= number; i++)
{
   Console.WriteLine($"{i*i} ");
}
*/
