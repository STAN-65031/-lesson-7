// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента


Console.WriteLine("Введите число столбцов  в массиве");
bool columns = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите число строк в массиве");
bool lines = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число которое необходимо найти в массиве");
bool DesiredNumber = int.TryParse(Console.ReadLine(), out int number);




int[,] CreatesArray(int str, int column)
{
    int[,] array = new int[str, column];
    Random random = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(0,10);
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
PrintArray(result);

void SearchesGivenNumber (int [,] array,  int DesiredNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (DesiredNumber == array[i,j])
            {
                Console.WriteLine($"Число {DesiredNumber} в массиве есть, находится по индексу {i} , {j}");
            }
        }
    }
}
SearchesGivenNumber(result, number);