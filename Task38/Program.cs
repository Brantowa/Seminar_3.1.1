﻿// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round (num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxNumber (double[] array)
{
    double max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max) max = array [i];
    }
    return max;
}

double MinNumber (double[] array)
{
    double min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min) min = array [i];
    }
    return min;
}

double[] arr = CreateArrayRndDouble(5, 1, 99);
double maxNum = MaxNumber(arr);
double minNum = MinNumber(arr);
double differenceMaxMin = maxNum - minNum;
double roundedResult = Math.Round (differenceMaxMin, 1);
PrintArray(arr);
Console.WriteLine($"Разница между max и min элементами массива -> {roundedResult}");