/* ### Задача 62: 
Заполните спирально массив 4 на 4. */

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    return array;

}

void PrintArray(int[,] array)
{
    int maxStr = array.GetLength(0);
    int maxCol = array.GetLength(1);

    for (int i = 0; i < maxStr; i++)
    {
        for (int j = 0; j < maxCol; j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void TraverseArray(int[,] array)
{
    int maxStr = array.GetLength(0);
    int maxCol = array.GetLength(1);
    int qtElem = maxStr * maxCol;

    int minStringIndex = 0;
    int maxStringIndex = maxStr - 1;
    int minColumnIndex = 0;
    int maxColumnIndex = maxCol - 1;

    int direction = 0;
    int currentString = maxStr - 1;
    int currentColumn = -1;
    int i = 1;

    while (i<=qtElem)
    {
        //Идём вправо    
        if ((currentColumn < maxColumnIndex) && (direction == 0))
        {
            if ((currentColumn + 1) == maxColumnIndex)
            {
                maxStringIndex--;
                direction = 1;
            }

            currentColumn++;
            //result[i] = array[currentString, currentColumn];
            array[currentString, currentColumn] = i;
        }
        //Идём вверх
        else if ((currentString > minStringIndex) && (direction == 1))
        {
            if ((currentString - 1) == minStringIndex)
            {
                maxColumnIndex--;
                direction = 2;
            }

            currentString--;
            //result[i] = array[currentString, currentColumn];
            array[currentString, currentColumn] = i;
        }
        //Идем влево
        else if ((currentColumn > minColumnIndex) && (direction == 2))
        {
            if ((currentColumn - 1) == minColumnIndex)
            {
                minStringIndex++;
                direction = 3;
            }

            currentColumn--;
            //result[i] = array[currentString, currentColumn];
            array[currentString, currentColumn] = i;
        }
        //Идём вниз
        else if ((currentString < maxStringIndex) && (direction == 3))
        {
            if ((currentString + 1) == maxStringIndex)
            {
                minColumnIndex++;
                direction = 0;
            }

            currentString++;
            //result[i] = array[currentString, currentColumn];
            array[currentString, currentColumn] = i;
        }

        else
        {
            break;
        }

        i++;
    }

  
}

Console.Clear();
int[,] array = GetArray(9,10);

TraverseArray(array);
PrintArray(array);