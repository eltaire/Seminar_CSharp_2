Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе число");
int b = Convert.ToInt32(Console.ReadLine());
int c = b % a;
   if (c == 0)
   {
    Console.WriteLine ("Второе число кратно первому");
   }
   else
   {
    Console.WriteLine ("Остаток при делении второго числа на первое равно " + c);
   }
