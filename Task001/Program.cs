﻿int CreateNumber ()
{
    int number = new Random().Next(10,100);
    return number;
    //{
    //return new Random().Next(10,100);
}

int MaxDigit(int number)
{
     int Decimal = number / 10;
     int Ed = number % 10;
     if (Decimal >= Ed)
     {
        return Decimal;
     }
     else
     {
        return Ed;
     }
}
int a = CreateNumber();
Console.WriteLine(a);
int maxDigit = MaxDigit(a);
Console.WriteLine(maxDigit);

