/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GenerateArray()
{
    Console.WriteLine("Введите размер массива:");
    int size = int.Parse(Console.ReadLine()!);
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(201)-100;
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

int sumOdds(int [] arr) {
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] arr = GenerateArray();
PrintArray(arr);
int sum = sumOdds(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
