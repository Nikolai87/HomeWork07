// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

int length = ReadInt("m");
int secondLength = ReadInt("n");
double[,] array = GetArray(length, secondLength);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

int ReadInt(string argument)
{
    Console.Write($"введите {argument}: ");
    return int.Parse(Console.ReadLine());
}

double[,] GetArray(int length, int secondLength)
{
    double[,] array = new double[length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 100, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

