//Task 10.  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int DisplayNumber(int num)
{
    int onenum = num / 10;
    int twonum = onenum % 10;
    return twonum;
}

Console.WriteLine("Hello, write a three-digit number");
int threedigitnumber = Convert.ToInt32(Console.ReadLine());
if (threedigitnumber < 100 || threedigitnumber >= 1000) // проверяет число и если оно не правильное, то не выводит его дальше
{
    Console.WriteLine("Вы вели неправильное число");
    return;
}

int finishnumbers = DisplayNumber(threedigitnumber);
Console.WriteLine($"Shows the number of {threedigitnumber} is {finishnumbers}");
*/

//Task 13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int NewNumber(int num)
{
    while(num > 999)
    {
       num /= 10;
    }
    return num % 10;
      
} 

Console.WriteLine("Hello, write a three-digit number");
int threedigitnumber = Convert.ToInt32(Console.ReadLine());
if(threedigitnumber < 99)
   {
    Console.WriteLine("третьей цифры нет");
   return;
   }

Console.WriteLine($"последняя цифра из числа {threedigitnumber} будет {NewNumber(threedigitnumber)}");
*/

//Task 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
bool ChekWekend(int number)
{
    if(number < 6 && number < 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Hello, write the day of the week");
int wekday = Convert.ToInt32(Console.ReadLine());
if (wekday > 7)
{
    Console.WriteLine("mistake, there is no such day in a week");
    return;
}
bool finish = ChekWekend(wekday);
if(finish == false)
{
    Console.WriteLine($"This day weekend");
}
else
{
    Console.WriteLine($"This day weekday");
}
*/