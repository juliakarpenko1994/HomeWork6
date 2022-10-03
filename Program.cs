/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
Console.Write($"Введите количество чисел: ");
double n = Convert.ToInt32 (Console.ReadLine());
double [] array = new double [n];

double [] GetNumbers(double n){
for (double i = 0; i < n; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32 (Console.ReadLine());
  }
  return array;
}

double SumPositiveValue(double [] array){
  double sum = 0;
  for (double i = 0; i < array.Length; i++)
  {
    if(array[i]>0){
      sum++;
    }
  }
  return sum;
}

GetNumbers(n);
System.Console.WriteLine($"Количество значений больше 0 -> {SumPositiveValue(array)}");*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
 уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32 (Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
