// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число, которое необходимо сложить: ");
int x = Convert.ToInt32(Console.ReadLine());

int Summ (int x)
{
int result = 0;
int count = Convert.ToString(x).Length;
int y = 0;
    for (int i = 0; i < count; i++)
    {
      y = x - x % 10;
      result = result + (x - y);
      x = x / 10;
    }
return result;
}
Console.WriteLine("Сумма цифр в числе: " + Summ(x));

