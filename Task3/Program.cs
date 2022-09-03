// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Array2(array);
void Array2(int[] array)
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,10);
        if(i == 0)
            Console.Write("[" + array[i] + ", ");
        else if (i >= 1 && i <= size-2)
            Console.Write(array[i] + ", ");
        else if (i == size-1)
            Console.WriteLine(array[i] + "]");
    }
}