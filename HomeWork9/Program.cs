// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n < 1) ShowNums(n + 1);
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
/*
int Sum(int m, int n)
{
    if(m < n)
    {
        return m + Sum(m + 1, n);
    }
    if(n < m) 
    {
        return n + Sum(m, n + 1);  
    }     
    return m;
}

Console.Write("Input a number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(m, n));
*/
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int AkkermanFunction(int m, int n)
{
if(m == 0) return n + 1;
if(m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
if(m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
return n + 1;
}
Console.Write("Input a number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunction(m, n));
*/