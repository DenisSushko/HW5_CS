/*Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить. */

int[] GenerateArray()
{
    Console.WriteLine("Введите размер массива:");
    int size = int.Parse(Console.ReadLine()!);
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(201) - 100;
    }
    return arr;
}

void PrintArrayInt(int[] arr)
{
    string str = "[";

    
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

void PrintArrayDouble(double[] arr)
{
    string str = "[";

    
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


double[] ArrayStat(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int maxIndex = 0;
    int minIndex = 0;
    double average = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            maxIndex = i;
        }
        if (arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
        average = average + arr[i];
    }
    average = average / arr.Length;
    double[] stats = { max, maxIndex, min, minIndex, average };
    return stats;
}

double Mediana(int[] arr)
{
    double med = 0;
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    if(arr.Length % 2 == 0) {
        med = ((double)arr[arr.Length / 2 - 1] + (double)arr[arr.Length / 2]) / 2;
    }
    else {
        med = arr[arr.Length / 2];
    }
    return med;
}

int[] arr = GenerateArray();
Console.WriteLine("Массив: ");
PrintArrayInt(arr);
double[] stats = ArrayStat(arr);
Console.WriteLine("Массив со статистикой: ");
PrintArrayDouble(stats);

Console.WriteLine($"Максимальный элемент массива: {stats[0]}, его индекс: {stats[1]}");
Console.WriteLine($"Минимальный элемент массива: {stats[2]}, его индекс: {stats[3]}");
Console.WriteLine($"Среднее арифметическое элементов масссива: {stats[4]}");
double med = Mediana(arr);
Console.WriteLine($"Медианное значение элементов масссива: {med}");
