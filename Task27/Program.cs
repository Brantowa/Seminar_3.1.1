// Напишите программу, которая
// принимает на вход число 
// выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberModul = number;
numberModul = Math.Abs(numberModul);
int Sum(int num)
{
    int sum = 0;
    int res = 0;
        while (num > 0)
    {
        res = num % 10;
        sum = sum + res;
        num = num / 10;
    }
    return sum;
}
int res = Sum(numberModul);
Console.WriteLine (res);