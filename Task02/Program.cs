﻿// Напишите программу, которая:
// 1. на вход принимает два числа  
// 2. выдаёт, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, min = {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"max = {number2}, min = {number1}");
}
else
{
    Console.WriteLine($"Числа равны ({number2} = {number1})");
}