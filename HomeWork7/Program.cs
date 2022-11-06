void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());    
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomDouble2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());    
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            array[i,j] = Math.Round(array[i,j], 2);
        }

    return array;
}

void ShowDouble2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}
/*
double[,] myArray = CreateRandomDouble2dArray();
ShowDouble2dArray(myArray);
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            // и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int ElementValue(int[,] array, int i, int j)
{
    int value = 1168;
    if(i < array.GetLength(0) && j < array.GetLength(1) && i > -1 && j > -1)
    {
        value = array[i,j];
        Console.Write("Element value: ");
    }
    else
    {
        Console.Write("Element not found! Error Code: ");
    }
    return value;
}

int[,] array = CreateRandom2dArray();
Console.Write("Input the rows: ");
int i = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input the columns: ");
int j = Convert.ToInt32(Console.ReadLine()) - 1;

Show2dArray(array);
Console.WriteLine(ElementValue(array, i, j));
*/

// Задача 3. Задайте двумерный массив из целых чисел. 
//          Найдите среднее арифметическое элементов в каждом столбце.
/*
double[] Average(int[,] array)
{
    double sum = 0;
    double[] myArray = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++, sum = 0) // много написано, но так красивее и быстрее работает, чем в тело записывать
        for(int i = 0; i < array.GetLength(0); myArray[j] = sum / array.GetLength(0), myArray[j] = Math.Round(myArray[j], 2), i++)
            sum += array[i, j];

    return myArray;
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
ShowArray(Average(array));
*/

