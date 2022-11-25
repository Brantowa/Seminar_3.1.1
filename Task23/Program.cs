// Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число ->");
int number = Convert.ToInt32(Console.ReadLine());
void Cube(int num)
{
    int num1 = 1;
    while (num1 <= num)
    {
        int res = num1 * num1 * num1;
        Console.WriteLine($"{num1,4} {res,6}");
        num1++;
    }
}
if (number > 0)
    Cube (number);
else Console.WriteLine("Число не является натуральным");