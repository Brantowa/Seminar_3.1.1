// Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве,
// 2. возвращает значение этого элемента 
// 3. или же указание, что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; // 0, 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) //2
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(min, max + 1); // 2- 3
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
else Console.Write($"{matrix[i, j], 4} ");
}
Console.WriteLine("|");
}
}
Console.WriteLine ("Введите индекс интересующей Вас строки");
Console.Write("Строка: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите индекс интересующего Вас столбца");
Console.Write("Столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
int result = 0;
if (row <= array2D.GetLength(0) && column <= array2D.GetLength(1))
{
result = array2D[row, column];
Console.WriteLine ($"{row}, {column} -> {result}");
}
else Console.WriteLine ($"{row}, {column} -> такого элемента в массиве нет");
