// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
System.Console.Write("Введите десятичное чиcло -> ");
int number = Convert.ToInt32(Console.ReadLine());

int TransToBinary(int num)
{
    int result = 0;
    int i = 1;

    while (num > 0)
    {
        result += num % 2 * i;
        num /= 2;
        i *= 10;
    }

    return result;

}

int transToBinary = TransToBinary(number);

Console.WriteLine($"Бинарное -> {transToBinary}");