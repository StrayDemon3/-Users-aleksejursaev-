// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) 
//           и возводит число A в натуральную степень B.
/*
double Exponentiation(double a, int b)
{
    double exp = a;
    for(int cur = 1; cur < b; cur++)
        exp *= a;
    return exp;
}

Console.Write("Input a number one: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a number two: ");
int b = Convert.ToInt32(Console.ReadLine());
double exp = Exponentiation(a, b);
Console.WriteLine(exp);
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int number)
{
    int num = number;
    int size;
    if(number > 0)
    {
    for(size = 1; num > 9; size++) //нашли колличество цифр
        num /= 10;
    }
    else
    {
    for(size = 1; num < -9; size++)
        num /= 10;
    }
    int[] array = new int[size];
    int div = Convert.ToInt32(Math.Pow(10, size - 1));;
    array[0] = number / div;
    div /= 10;
    int sum = array[0];
    int i = 1;
    while(i < size)
    {
        array[i] = number / div % 10;
        div /= 10;
        sum += array[i];
        i++;
    }
    return sum;
}

Console.Write("Input a number one: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));
*/

// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomeArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i ++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a size: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = (CreateRandomeArray(m, min, max));
ShowArray(myArray);