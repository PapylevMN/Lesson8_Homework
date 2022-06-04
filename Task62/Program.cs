int[,] CreateArray()
{
    int size = 4;
    int[,] array = new int[size,size];
    int num = 1;
    for (int j = 0; j < size; j++)
    {
        array[0,j] = num;
        num+=1;
    }
    for (int i = 1; i < size; i++)
    {
        array[i,size-1] = num;
        num+=1;
    }
    int side = 1;
    for (int j = size-1-side; j > 0-side; j--)
    {
        array[size-1,j] = num;
        num +=1;
    }
    for (int i = size - 1- side; i > 0; i--)
    {
        array[i,0] = num;
        num +=1;
    }

    int circle = 1;
    for (int j = 0 + side; j < size-side; j++)
    {
        array[0+circle,j] = num;
        num+=1;
    }
    for (int i = 1+circle; i < size-circle; i++)
    {
        array[i,size-1-circle] = num;
        num+=1;
    }
    side +=1;
    for (int j = size-1-side; j > 0; j--)
    {
        array[size-1-circle,j] = num;
        num +=1;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = CreateArray();
PrintArray(array);