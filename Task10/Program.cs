// Напишите программу, которая 
// 1. принимает на вход трёхзначное число 
// 2. на выходе показывает вторую цифру этого числа
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите любое трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);
// int remainder1 = number % 10;
// int rounding = number - remainder1;
// int remainder2 = rounding % 100;
// int result = remainder2 / 10;
// if (number > 99 && number < 1000) Console.WriteLine(result);
// else Console.WriteLine($"{number} не является трехзначным числом");

Console.WriteLine("Введите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numberModul = number;
numberModul = Math.Abs(numberModul);

int firstDigit = numberModul / 100;
int secondDigit = numberModul % 10;
int thirdDigit = firstDigit * 100 + secondDigit;
int result = (numberModul - thirdDigit) / 10;

if (numberModul > 99 && numberModul < 1000) Console.WriteLine($"Вторая цифра от {number} это {result}");
else Console.WriteLine($"{number} не является трехзначным числом");