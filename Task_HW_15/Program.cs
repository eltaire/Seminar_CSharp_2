//Задача 15
Console.Write("Введите день недели в виде цифры: ");
int DayDigit = Convert.ToInt32(Console.ReadLine());

void LookForWeekEnd (int DayDigit) 
{
  if (DayDigit == 6 || DayDigit == 7) 
  {
  Console.WriteLine("Это выходной день!");
  }
  else if (DayDigit < 1 || DayDigit > 7) 
  {
    Console.WriteLine("В неделе не может быть столько дней, будьте внимательны и попробуйте еще раз!");
  }
  else Console.WriteLine("Этот день не выходной.");
}

LookForWeekEnd(DayDigit);
