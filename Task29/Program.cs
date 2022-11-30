// Напишите программу, которая 
// 1. задаёт массив из 8 элементов 
// 2. выводит их на экран
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];
void FillArray(int[] arr)
{
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 101);
}
}
void PrintArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write($"{arr[i]}, ");
}
Console.Write($"{arr[arr.Length-1]}]");
}
FillArray(array);
PrintArray(array);