//Задача 10

Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int FindNumbers(int a)
{
    int FirstNmb = a / 10;
    int result = FirstNmb % 10;
    return result;
}
int b = FindNumbers(a);
Console.WriteLine("Вторая цифра Вашего числа равна " + b);