Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine(); 
int number = Convert.ToInt32(numberStr); 

   for (int i = 2; i <= number;)
{
    Console.Write(i + ", ");
    i = i +2;
}

