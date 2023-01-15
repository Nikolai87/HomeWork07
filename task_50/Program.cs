// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int length = ReadInt("введите m: ");
int secondLength = ReadInt("введите n: ");
Console.WriteLine();
int i = ReadInt("введите индекс i: ");
int j = ReadInt("введите индекс j: ");
Console.WriteLine();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.WriteLine();
ElementValue(array);
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

void ElementValue(int[,] array)
{
    if (i <= array.GetLength(0) && j <= array.GetLength(1))
    {
        Console.WriteLine($"ваш элемент: {array[i, j]}");
    }
    else
    {
        Console.WriteLine($"такого элемента нет");
    }

}
