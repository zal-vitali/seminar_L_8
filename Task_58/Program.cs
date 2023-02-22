/* ### Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц. */

//Мой код не работает и я не знаю, почему.
//Мой код работает и я не знаю, почему.

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

int[,] MultiplyMattrix(int[,] matrix1, int[,] matrix2)
{
    int size = matrix1.GetLength(0) < matrix1.GetLength(1) ? matrix1.GetLength(0) : matrix1.GetLength(1);
    int[,] result = new int[size, size];
    int sumCell = 0;

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            sumCell = 0;
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {

                    sumCell += matrix1[k, i] * matrix2[j, k];

            }

            result[i, j] = sumCell;
        }
    }

    return result;
}

Console.Clear();
Console.WriteLine("Задайте размерность массива. Количество строк:");
int nRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество колонок:");
int nCol = int.Parse(Console.ReadLine()!);

int[,] matrix1 = GetArray(nRow, nCol, 1, 10);
int[,] matrix2 = GetArray(nCol, nRow, 1, 10);

Console.WriteLine();
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(MultiplyMattrix(matrix1, matrix2));