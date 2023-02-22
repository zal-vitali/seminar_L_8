/* ### Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива. */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }

}

void SortArray(int[,] inArray)
{
    int maxValue;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            maxValue = inArray[i, j];
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, k] > maxValue)
                {
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = maxValue;
                    maxValue = inArray[i, j];
                }
            }
        }
    }
}

Console.Clear();
int[,] array = GetArray(4, 4, -10, 10);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
