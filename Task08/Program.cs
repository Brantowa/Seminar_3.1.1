// Напишите программу, которая:
// 1. на вход принимает число (N) 
// 2. на выходе показывает все чётные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int count = 2;

while (count <= number)
{
   if (count % 2 == 0)
   {
 Console.Write($"{count} ");
 count = count + 1;
   } 
    else count = count + 1;
}