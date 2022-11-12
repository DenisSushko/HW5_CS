/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GenerateArray()
{
    Console.WriteLine("Введите размер массива:");
    int size = int.Parse(Console.ReadLine()!);
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(900)+100;
    }
    return arr;
}

void PrintArray(int[] arr)
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
            str = str + arr[i] + ", ";
    }
    Console.WriteLine(str);
}

int countEvens(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

int[] arr = GenerateArray();
PrintArray(arr);
int count = countEvens(arr);
Console.WriteLine($"Количество четных чисел в массиве: {count}");
