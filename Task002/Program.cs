int CreateNewNumber()
{
    int number = new Random().Next(100,1000);
    return number;
    //{
    //return new Random().Next(10,100);
}

int a = CreateNewNumber();
int FirstNmb = a / 100;
int SecondNmb = a % 10;
Console.WriteLine(a);
Console.Write(FirstNmb);
Console.Write(SecondNmb);

