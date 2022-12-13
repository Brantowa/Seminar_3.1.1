// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] InputArray()
{
    Console.WriteLine("Уточните общее количество элементов будущего массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int AboveZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result = result + 1;
    }
    return result;
}

int[] arr = InputArray();
PrintArray(arr);
int result = AboveZero(arr);
Console.WriteLine($"Общее количество чисел в масиве > 0 составило -> {result}");
