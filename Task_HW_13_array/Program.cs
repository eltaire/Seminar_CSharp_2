//Задача 13 array
Console.Write("Введите число: ");
int IfNumber = Convert.ToInt32(Console.ReadLine());
string IfString = Convert.ToString(IfNumber);
int lenght = IfString.Length;
if (lenght > 2)
{
  Console.WriteLine("Третья цифра Вашего числа равна " + IfString[2]);
}
else {
  Console.WriteLine("В Вашем числе нет третьей цифры");
}