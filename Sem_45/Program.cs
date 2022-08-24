// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] CopyArrayInt(int[] array)
{
    int[] arraynew = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arraynew[i] = array[i];
    }

    return arraynew;
}

int[] arr = CreateArrayRndInt(5, 1, 10);

int [] arr2 = CopyArrayInt(arr);

arr2[0] = 11;

PrintArray(arr);
PrintArray(arr2);