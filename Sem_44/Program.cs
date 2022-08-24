// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());


void GetFibonacci(int n)
{
    int prevPrev = 0;
    int prev = 1;


    System.Console.Write($"{prevPrev} {prev} ");
    for (int i = 3; i <= n; ++i)
    {

        int result = prev + prevPrev;
        System.Console.Write(result + " ");
        prevPrev = prev;
        prev = result;
    }

}

GetFibonacci(num);