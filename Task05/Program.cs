// Напишите программу:
// 1. на вход принимает одно число (N)
// 2. на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите любое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = number1 * 2;
int test = number1 * 2;
int result = 0;
while (count >= 0)
{
    result = number1 - count;
    Console.Write($"{result} ");
    count = count - 1;
}
