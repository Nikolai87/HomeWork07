//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int length = ReadInt("введите m: ");
int secondLength = ReadInt("введите n: ");
Console.WriteLine();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.WriteLine();
AverageMeanOfColumnElements(array);
Console.WriteLine();

int ReadInt(string argument)
{
    Console.Write($"{argument} ");
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageMeanOfColumnElements(int[,] array)
{
    double average = 0;
    double sum = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == k)
                    sum += array[i, j];
            }
        }
        average = sum / array.GetLength(0);
        Console.WriteLine($"среднее арифметическое {k + 1} столбца равно {Math.Round(average, 1)}");
        sum = 0;
    }
}