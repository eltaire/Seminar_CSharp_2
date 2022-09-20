//Задача 14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

void DoubleCheck (int a)
{
    if (a % 7 == 0 & a % 23 == 0)
    {
        Console.WriteLine("Ваше число кратно числам 7 и 23");
    }
    else if (a % 7 == 0 )
    {
        Console.WriteLine("Ваше число кратно только 7"); 
    }
    else if (a % 23 == 0)
    {
        Console.WriteLine("Ваше число кратно только 23"); 
    }
    else Console.WriteLine("Ваше число не является кратным ни 7, ни 23");

}
DoubleCheck(a);