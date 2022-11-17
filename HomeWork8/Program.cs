
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

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


// Задача 1. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void Sorting(int[,] array) // весь массив
{
    for(int iMin = 0; iMin < array.GetLength(0); iMin++)
        for(int jMin = 0; jMin < array.GetLength(1); jMin++)
            for(int i = 0; i < array.GetLength(0); i++)
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] < array[iMin, jMin])
                    {
                        int temp = array[i, j];
                        array[i,j] = array[iMin, jMin];
                        array[iMin, jMin] = temp;
                    }
                }
}
*/
/*
void Sorting(int[,] array) // построчно
{
    for(int iMin = 0, i = 0; iMin < array.GetLength(0); iMin++, i++)
        for(int jMin = 0; jMin < array.GetLength(1); jMin++)
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] > array[iMin, jMin])
                {
                    int temp = array[i, j];
                    array[i,j] = array[iMin, jMin];
                    array[iMin, jMin] = temp;
                }
            }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Sorting(myArray);
Show2dArray(myArray);
*/

// Задача 2.Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int MinLineAmount(int[,] array) // находит первое минимальное. Если нужно было бы все, то через void бы записал.
{
    int sum = 0;
    int line = 1;
    int currentSum = 0;
    for(int i = 0; i < array.GetLength(0); i++, currentSum = 0)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
            if(j == array.GetLength(1) - 1)
            {
                if(i == 0) sum = currentSum;
                if(currentSum < sum) 
                {
                    sum = currentSum;
                    line = i + 1;
                }
            }
        }
    }
    return line;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int line = MinLineAmount(myArray);
Console.WriteLine("Minimum amount in line " + line);
*/

// Задача 3.Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] ProductOfTwoMatrices(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int [arrayA.GetLength(0), arrayB.GetLength(1)];

        if(arrayA.GetLength(1) == arrayB.GetLength(0))
        {
            for(int i = 0, iA = 0; i < arrayC.GetLength(0); i++, iA++)
                for(int j = 0, jB = 0; j < arrayC.GetLength(1); j++, jB++)                
                    for(int jA = 0, iB = 0, sum = 0;
                        jA < arrayA.GetLength(1); 
                        jA++, iB++)
                        {
                            sum = arrayA[iA,jA] * arrayB[iB,jB] + sum;
                            arrayC[i,j] = sum;
                        }
        }
        else
        {
            Console.WriteLine("It is impossible to calculate the product of matrices");
            for (int i = 0; i < arrayC.GetLength(0); i++)
                for (int j = 0; j < arrayC.GetLength(1); j++)
                arrayC[i, j] = 0;
        }
    return arrayC;
}

int[,] myArrayA = CreateRandom2dArray();
Show2dArray(myArrayA);
int[,] myArrayB = CreateRandom2dArray();
Show2dArray(myArrayB);
int[,] myArrayC = ProductOfTwoMatrices(myArrayA, myArrayB);
Show2dArray(myArrayC);
*/

// Задача 4.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
bool ExcludeRecurring(int[,,] array, int num)
{
    bool answer = true;
    for(int k = 0; k < array.GetLength(2); k++)
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
                if(array[i, j, k] == num)
                    answer = false;
    
    return answer;
}

int[,,] Array3D(int rows, int columns, int plane)
{
    int[,,] array = new int[rows, columns, plane];
    for(int k = 0; k < plane; k++)
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            {
                int num = new Random().Next(10, 100);
                bool random = ExcludeRecurring(array, num);
                if(random == true)
                {
                    array[i, j, k] = num;
                }
                else
                {
                    while(random == false)
                        {
                            num = new Random().Next(10, 100);
                            random = ExcludeRecurring(array, num);
                            array[i, j, k] = num;
                        }
                }
            }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j, k] + " ");
            Console.WriteLine("");
        }
        Console.WriteLine("------");
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of planes: ");
int plane = Convert.ToInt32(Console.ReadLine());

if(rows * columns * plane < 90)
{
int[,,] my3DArray = Array3D(rows, columns, plane);
Show3dArray(my3DArray);
}
else
Console.WriteLine("Not enough elements");
*/


// Задача 5 Напишите программу, которая заполнит спирально массив.
/* //уверен, что можно сократить, но я слишком долго с этим провозился
int[,] SpiralArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    int t  = 0;
    int str = 0;

    for(int count = 0, i = 0, j = 0; count < array.Length;)
    {
        for(i = str, j = t;
            j < columns; 
            j++, count++)
        {
            if(count == array.Length) break;
            array[i, j] = count + 1;
        }
        columns--;
        for(i++, j = columns;
            i < rows;
            i++, count++)
        {
            if(count == array.Length) break;
            array[i, j] = count  + 1;
        }
        rows--;
        for(i = rows, j = columns - 1;
            j > t - 1; 
            j--, count++)
        {
            if(count == array.Length) break;
            array[i, j] = count  + 1;
        }
        for(i = rows - 1, j = t;
            i > str; 
            i--, count++)
        {
            if(count == array.Length) break;
            array[i, j] = count + 1;
        }
        t++;
        str++;

    }


    return array;
}
int[,] myArray = SpiralArray();
Show2dArray(myArray);
*/


