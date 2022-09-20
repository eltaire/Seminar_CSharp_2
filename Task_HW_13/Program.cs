//Задача 13 тяжко
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine()); //само число
int b = a.ToString().Length; //его длина
int ThirdDigit (int a, int b)
{
int thirdDigit = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры не обнаружено ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        thirdDigit = (a / c) % 10;
    }
return thirdDigit;
}
Console.Write(ThirdDigit(a, b));