/* ### Задача 60: 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

int[,,] GetArray(int axisX, int axisY, int axisZ)
{
    int[,,] array = new int[axisX, axisY, axisZ];
    int initVal = 10;

    for (int i = 0; i < axisX; i++)
    {
        for (int j = 0; j < axisY; j++)
        {
            for (int k = 0; k < axisZ; k++)
            {
                array[i, j, k] = initVal;
                initVal++;
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array3D)
{

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }

            Console.WriteLine();
        }

    }

}

Console.Clear();
int[,,] array3D = GetArray(3, 4, 5);

PrintArray(array3D);