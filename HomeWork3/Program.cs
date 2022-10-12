// Exercise 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int NumberOfDigits(int num)
{
    int div = 10;
    int cur = 1;
    int n = num;
    
    while(n > 10)
    {
        n = num / div;
        div *= 10;
        cur ++;
    }
    return cur;
}

//    Console.WriteLine("Enter a number ");
//int num = Convert.ToInt32(Console.ReadLine());
//int res = NumberOfDigits(num);
//Console.WriteLine(res);

bool Palindrome(int num)
{
    bool result;
    int numOfDigits = NumberOfDigits(num);
    int current = 1;
    int div1 = 1;
    for(int cur = 1; cur < numOfDigits; cur ++)
        div1 *= 10;
    int div2 = 10;
    int remainder = 100;
    int res = 0;
    if(num / div1 == num % 10)  //сравнили первую и последнюю цифры
    {
        res = 1;
        div1 /= 10;
    }
    else
    {
        result = false;
        return result;
    }
    while(current <= numOfDigits / 2)
    {
        int dig1 = num / div1 % 10;
        int digL = num  % remainder / div2;
        if(dig1 == digL)
        {
            res = 1;
        }
        else
        {
            res = 0;
            break;
        }
        div1 /= 10;
        div2 *= 10;
        remainder *= 10;
        current ++;
    }
    if(res == 1)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

Console.WriteLine("Enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Palindrome(num);
if(num > 10)
{
if(res == true)
{
    Console.WriteLine($"number {num} is palindrome");
}
else
{
    Console.WriteLine($"number {num} is not palindrome");
}
}
else
{
    Console.WriteLine("incorrect number entered");
}
*/
// Могу дописать для отрицательных, но что-то я с ней уже провозился долго.

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xA, double xB, double yA, double yB, double zA, double zB)
{
    double abz = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return abz;
}

Console.Write("Input xA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Distance(xA, xB, yA, yB, zA, zB), 4));

*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{
    for(int cur = 1; cur <= n ; cur++)
        Console.Write($"{Math.Pow(cur, 3)} ");
}

Console.Write("Input a number: ");
int n = Convert.ToInt16(Console.ReadLine());
Cube(n);