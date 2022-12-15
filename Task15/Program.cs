// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели
// 2. проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Чтобы узнать, является ли данный день недели выходным, введите любое число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 ^ number == 7) System.Console.WriteLine ($"{number} день недели является выходным");
else if (number > 7 ^ number < 1) System.Console.WriteLine ($"{number} не соответствует никакому дню недели");
else if (number > 0 && number < 6) System.Console.WriteLine ($"{number} день недели не является выходным");