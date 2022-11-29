
// Напишите программу, которая 
// 1. принимает на вход пятизначное число 
// 2. проверяе, является ли оно палиндромом
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    return num1 == num5 && num2 == num4;
}

Console.WriteLine ("Введите натуральное пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Palindrome(number);
string resultStr = result ? "Да" : "Нет";
if (number > 9999 && number < 100000)
Console.WriteLine ($"{number} -> {resultStr}");
else Console.WriteLine ("Число не является натуральным пятизначным");