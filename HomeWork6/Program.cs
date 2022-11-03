// Задача 1. Пользователь вводит с клавиатуры M чисел. 
        //Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Enter amount of numbers: ");
int amount = Convert.ToInt32(Console.ReadLine());

int positive = 0;
for(int count = 0; count < amount; count++)
{
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num > 0) positive++;
}

Console.WriteLine(positive + " positive numbers");
*/

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
            //значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void LineIntersectionPoint(double b1, double b2, double k1, double k2)
{
    double variable1 = k1-k2;
//    Console.WriteLine(variable1);
    double variable2 = b1-b2;
//    Console.WriteLine(variable2);
    double x = -1 * variable2 / variable1;
//    Console.WriteLine(x);
    double y = k2 * x + b2; // не корректно считает с отрицательными переменными :(
//    Console.WriteLine(y);

    Console.WriteLine("Point x = " + x);
    Console.WriteLine("Point y = " + y);
}

Console.Write("Enter enter value b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter enter value b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter enter value k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter enter value k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

LineIntersectionPoint(b1, b2, k1, k2);