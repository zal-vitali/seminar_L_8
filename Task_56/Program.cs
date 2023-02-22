/* ### Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

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

int RowMinSumElements(int[,] inArray)
{
    int rowIndex = 0;
    int minSum = 0;
    int currentSum = 0;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            currentSum += inArray[i, j];
        }
        if (i == 0) minSum = currentSum;
        else
        {
            if (currentSum < minSum)
            {
                minSum = currentSum;
                rowIndex = i;
            }      
        }
        currentSum = 0;
    }

    return rowIndex + 1;
}

Console.Clear();
int[,] array = GetArray(4, 4, -10, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов - {RowMinSumElements(array)}");

