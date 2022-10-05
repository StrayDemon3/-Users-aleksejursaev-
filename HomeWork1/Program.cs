

// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write ("Input the first number ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input the second number ");
int secondNum = Convert.ToInt32(Console.ReadLine());

while (firstNum != secondNum)
{
    if(firstNum > secondNum)
    {
        Console.WriteLine("max is " + firstNum);
        Console.WriteLine("min is " + secondNum);
    }
    else
    {
        Console.WriteLine("max is " + secondNum);
        Console.WriteLine("min is " + firstNum); 
    }
break;
}
if(firstNum == secondNum)
{
    Console.WriteLine("the numbers are equal");
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write ("Input the first number ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input the second number ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input the third numbers ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if (secondNum > firstNum && secondNum > thirdNum)
{
   max = secondNum;
}

if (thirdNum > firstNum && thirdNum > secondNum)
{
   max = thirdNum;
}


Console.WriteLine(max);
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.Write("Enter the number ");
int num = Convert.ToInt32(Console.ReadLine());
while(num != 0)
{
    if(num % 2 == 0)
    {
        Console.WriteLine("Number is even");
    }
    else
    {
        Console.WriteLine("Sorry, but number is not even");
    }
    break;
}

if(num == 0)
{
    Console.WriteLine("Can't divide by zero");
}int negCur = -2;
*/
// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Enter a number ");
int cur = 2;

int N = Convert.ToInt32(Console.ReadLine());
if(N == 0)
{
    Console.WriteLine("No even numbers");
}

while(cur <= N)
{
    Console.Write(cur +" ");

    cur += 2;
}

int negCur = -2;

while(negCur >= N)
{
    Console.Write(negCur + " ");
    negCur -= 2;
}
*/
