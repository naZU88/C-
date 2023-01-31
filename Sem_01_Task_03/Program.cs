Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); 
int number = Convert.ToInt32(numberStr); 

for (int i = - number; i <= number; i++)
{
Console.Write(i + ", ");
}
