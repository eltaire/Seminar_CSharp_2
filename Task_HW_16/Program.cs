// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int A = a*a;
int B = b*b;
void CheckingSquare (int a, int b, int A, int B)
{
    if (a == B || b == A)
    {
       Console.WriteLine("Одно число является квадратом другого"); 
    }
    else
    {
        Console.WriteLine("Одно число не является квадратом другого"); 
    }
}
CheckingSquare (a, b, A, B);