int CreateNewNumber()
{
    int number = new Random().Next(100,1000);
    return number;
}

int FindNumbers(int number)
{
    int FirstNmb = number / 100;
    int SecondNmb = (number % 10) % 10;
    int result = FirstNmb * 10 + SecondNmb;
    return result;
}

int a = CreateNewNumber();
int b = FindNumbers(a);
Console.WriteLine(a);
Console.Write(b);