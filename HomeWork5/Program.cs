// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
/*
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;
int[] myArray = CreateRandomeArray(size, minValue, maxValue);
ShowArray(myArray);

int CountEvenNumbers(int[] myArray)
{
    int countEven = 0;
    for(int i = 0; i < myArray.Length; i++)
        if(myArray[i] % 2 == 0) countEven ++;
    return countEven;
}
Console.WriteLine(CountEvenNumber(myArray));

*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;
int[] myArray = CreateRandomeArray(size, minValue, maxValue);
ShowArray(myArray);

int SumOddNumbers(int[] myArray)
{
    int sum = 0;
    for(int i = 0; i < size; i++)
        if(myArray[i] % 2 == 1) sum += myArray[i];
    return sum;
}
Console.WriteLine(SumOddNumbers(myArray));
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 1;
int maxValue = 99;
int[] myArray = CreateRandomeArray(size, minValue, maxValue);
ShowArray(myArray);

int Min(int[] myArray)
{
    int min = myArray[1];
    for(int i = 0; i < size; i++)
        if(myArray[i] < min) min = myArray[i];

    return min;
}

int Max(int[] myArray)
{
    int max = myArray[0];
    for(int i = 0; i < size; i++)    
        if(myArray[i] > max) max = myArray[i];

    return max;
}

int result = Max(myArray) - Min(myArray);
Console.WriteLine(result);
*/