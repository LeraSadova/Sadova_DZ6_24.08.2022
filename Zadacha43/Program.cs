// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

//задаем массивы, тип данных выберем double
double[,] coefficient = new double[2,2];
double[] intersectionPoint=new double[2];


void EnteringCoefficients()//функция для ввода коэффициентов для уравнения:
{
  for (int i=0; i<coefficient.GetLength(0); i++) //у нас будет два уровнения, поэтому до 2 выполнять цикл
  {
    Console.WriteLine($"Для {i+1}го уравнения (y = k * x + b) введи коэффициенты: ");
    for (int j=0; j<coefficient.GetLength(1); j++)
    {
      if (j==0) Console.WriteLine("Введи значение коэффициента k:");
      else Console.WriteLine("Введи значение коэффициента b:");
      coefficient[i,j]=Convert.ToInt32(Console.ReadLine());
      
    }
  }
}
//функция для поиска точки пересечения
double[] Solution(double[,] coefficient)
{
  intersectionPoint[0]=(coefficient[1,1]-coefficient[0,1])/(coefficient[0,0]-coefficient[1,0]);
  intersectionPoint[1]=intersectionPoint[0]*coefficient[0,0]+coefficient[0,1];
  return intersectionPoint;
}

void ImportSolution(double[,] coefficient)
{ //проверка на совпадаение
  if (coefficient[0,0]==coefficient[1,0]&&coefficient[0,1]==coefficient[1,1])
  {
    Console.WriteLine("Заданные прямы совпадают друг с другом");
  }
  else if (coefficient[0,0] == coefficient[1,0] && coefficient[0,1] != coefficient[1,1])
  { //проверка на параллельность
    Console.WriteLine("Заданные прямы параллельны друг другу. ТОчки пересечения нет");
  }
  else 
  {
    Solution(coefficient);
    Console.WriteLine($"Координаты точки пересечения прямых: ({intersectionPoint[0]};{intersectionPoint[1]})");
  }
}
EnteringCoefficients();
ImportSolution(coefficient);