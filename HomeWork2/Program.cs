// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}

Console.Write("Enter a tree-digit number ");
int numbers = Convert.ToInt32(Console.ReadLine());
int res = SecondDigit(numbers);
Console.WriteLine("Second digit is " + res);
*/
// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int FindThirdPositiveDigit(int number)
{
    while(number > 999)
    {
        number = number / 10;
    }
    return number;
}
int FindThirdNegativeDigit(int number)
{
    while(number < -999)
    {
        number = number / 10;
    }
    return number;
}

Console.Write("Enter a number ");
int number = Convert.ToInt32(Console.ReadLine());
while(number < 100 && number > -100)
{
    Console.WriteLine("No third digit");
    break;
}
while(number > 100 || number < -100)
{
    if(number > 99)
    {
        int res = FindThirdPositiveDigit(number) % 10;
        Console.WriteLine("Third digit is " + res);
    }
    else
    {
        int res = FindThirdNegativeDigit(number) % 10;
        Console.WriteLine("Third digit is " + res);
    }
    break;
}
// Не работает с большими числами, полагаю, потому, что Int32. Но с другими мы пока не работали.
// Ну и если число начинается с нуля, то нули пропускает. Можно, полагаю, тоже прописать, но, возвожно, их и не нужно учитывать. Тут уж надо уточнять тех. задание у заказчика :)
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool WeekendOrNotWeekend(int day)
{
    bool result;
    if(day > 5)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

Console.Write("Enter a number from 1 to 7 ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

bool weekend = WeekendOrNotWeekend(dayOfTheWeek);
Console.WriteLine("Weekend "+ weekend);

// Можно добавить, чтобы больше 7 и меньше 1 выводило ошибку, но в задачке этого нет, Вы говорили, что лишнее делать тоже плохо, чтобы не забивать лишнее место.