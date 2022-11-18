// Программа, которая:
// 1. На вход принимает два числа и 
// 2. Проверяет, является ли первое число квадратом второго
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
int square2 = number2 * number2;
if (number1 == square2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"{number1} не является квадратом {number2}");
}

