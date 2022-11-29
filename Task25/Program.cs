// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    int result = 1;
    int i = 1; 
    while (i < num2)
        result = num1 * num1;
        i++;
    return result;
}
int exponentiation = Exponentiation(number1,number2);
Console.WriteLine ($"{number1} в степени {number2} -> {exponentiation}");