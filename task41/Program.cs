// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int[] CreateArray(int size) //Ввод массива с клавиатуры
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int GetSumPosElem(int[] array) //Массив считает количество положительных элементов массива
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[] array) //Печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

Console.Clear();
Console.Write("Сколько чисел хотите ввести? ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[] array = CreateArray(sizeArray);
PrintArray(array);
Console.WriteLine();
int SumPosElem = GetSumPosElem(array);
Console.WriteLine($"Количество чисел больше 0 =  {SumPosElem} ");