//https://github.com/AlexandrYodaXD/HomeWorks/blob/main/C%23/hw3/Program.cs

// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current ++)
        sum += current;
    
    return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/
// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumberOfDigits(int num)
{
    int div = 10;
    int cur = 1;
    
    for(int n = num; n > 10; cur ++)
    {
        n = num / div;
        div *= 10;
    }
    return cur;
}

Console.WriteLine("Enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
int res = NumberOfDigits(num);
Console.WriteLine(res);



*/
//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int N)
{
    int fact = 1;
    for(int current = 1; current <= N;current++)
        fact *= current;
    
    return fact;
}

Console.WriteLine("Enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
int fact = Factorial(num);
Console.WriteLine(fact);

*/

// Задача 4. Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomeArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size, i ++)
        newArray[i] = newRandome().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        
    }
}

