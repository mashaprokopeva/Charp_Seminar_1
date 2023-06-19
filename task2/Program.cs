// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("ВВедите первое число: ");
int Inputnumber1, Inputnumber2;
Inputnumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число: ");
Inputnumber2 = Convert.ToInt32(Console.ReadLine());

Boolean A = Inputnumber1 > Inputnumber2;
Boolean B = Inputnumber1 < Inputnumber2;
Boolean C = Inputnumber1 == Inputnumber2;

if (A)
{
System.Console.WriteLine("Число" + " " + Inputnumber1 + " " + "больше" + " " + Inputnumber2);
}
else if (B)
{
    System.Console.WriteLine("Число" + " " + Inputnumber1 + " " + "меньше" + " " + Inputnumber2);
}
else
{
  System.Console.WriteLine("Число" + " " + Inputnumber1 + " " + "равно" + " " + Inputnumber2);  
}

