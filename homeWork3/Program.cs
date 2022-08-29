// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите число столбцов  в массиве");
bool columns = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите число строк в массиве");
bool lines = int.TryParse(Console.ReadLine(), out int m);

int[,] CreatesArray(int str, int column)
{
    int[,] array = new int[str, column];
    Random random = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(0, 10);
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

int[,] result = CreatesArray(m, n);
Console.WriteLine();
PrintArray(result);

double[] FindsArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        result[i] = sum / array.GetLength(0);
    }
    return result;
}



double[] gap = FindsArithmeticMean(result);

void PrintResult(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine();
PrintResult(gap);