// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите три натуральных числа");

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

bool TriangleCheck(int number1, int number2, int number3)
{
    int max = number1;
    if (number2 > max) max = number2;
    if (number3 > max) max = number3;

    return (number1 + number2 + number3 - max) > max;
}

bool result = TriangleCheck(num1,num2,num3);

System.Console.WriteLine(result ? "Такой треугольник существует" : "Такой треугольник не существует");