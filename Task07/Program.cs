// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int remainder = 0;
if (number > 99 && number < 1000)
{ 
    remainder = number % 10;
    Console.WriteLine($"Последняя цифра от {number} - {remainder}");
}  
else
{
    Console.WriteLine($"{number} не является трехзначным числом");
}
