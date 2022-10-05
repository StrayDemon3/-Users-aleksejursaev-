// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindBiggestDigit(int num)
{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if(ed > dec)
        max = ed;
    else
        max = dec;
    return max;
}

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);
Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int RemovingADigitFromAThreeDigitNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
int number = new Random().Next(100,1000);
int res = RemovingADigitFromAThreeDigitNumber(number);
Console.WriteLine("Removing A Digit From A Three Digit Number " + res);
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b. a и b - инфо от пользователя(тоже int) 

bool MultipleOfTwoVariables(int num, int a, int b)
{
    bool result;

    if (num % a == 0 && num % b == 0)
    {
        result = true;
    }
    else
    {
        result = false;
    }

    return result;
}
Console.Write("Enter a divisor ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the first divisor ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second divisor ");
int b = Convert.ToInt32(Console.ReadLine());
bool res = MultipleOfTwoVariables(number, a, b);
Console.WriteLine("Multiple Of Two Variables is" + res);

