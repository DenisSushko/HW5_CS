/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. */

double[] GenerateArray()
{
    Console.WriteLine("Введите размер массива:");
    int size = int.Parse(Console.ReadLine()!);
    Random rnd = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100), 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    string str = "[";

    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            str = str + arr[i] + "]";
        }
        else
            str = str + arr[i] + "; ";
    }
    Console.WriteLine(str);
}

double MaxMinDifference (double[] arr) {
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) {
            max = arr[i];
        }
        if(arr[i] < min) {
            min = arr[i];
        }
    }
    return Math.Round(max - min, 2);
}

double[] arr = GenerateArray();
PrintArray(arr);
double diff = MaxMinDifference(arr);
Console.WriteLine($"Разница между максимальным и минимальным значением: {diff}");