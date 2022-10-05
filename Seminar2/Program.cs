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

int RemovingADigitFromAThreeDigitNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
int number = 123;
int res = RemovingADigitFromAThreeDigitNumber(number);
Console.WriteLine(res);


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b. a и b - инфо от пользователя(тоже int) 


