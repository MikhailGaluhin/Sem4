/*Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.*/


int FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        array[index] = new Random().Next(1, 8);
        index++;
    }
    return array;
}
int Array = FillArray(array);
for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine(Array[i]);
}
