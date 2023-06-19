// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("ВВедите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;
if (number > 1)
{
while (index <= number ){
  System.Console.WriteLine(index + " ");  
index = index +2;
}
}