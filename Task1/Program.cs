// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Введите число A, которое возводим в степень: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, B: ");
int y = Convert.ToInt32(Console.ReadLine());

int stepen (int x, int y)
{
    return (int) Math.Pow(x, y);
}
System.Console.WriteLine("Результат: " + stepen(x, y));
    
