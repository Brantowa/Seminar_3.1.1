// Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int numberModul = number;
numberModul = Math.Abs(numberModul);
int count = numberModul;

if (numberModul > 99)
{
    while ((count - 99) > 900)
    {
        count = count / 10;
    }
    count = count % 10;
    Console.WriteLine($"Третья цифра от {number} это {count}");
}
else
    Console.WriteLine("Третьей цифры нет");