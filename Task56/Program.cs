
int[,] CreateArray()
{
    Console.WriteLine("Введите размер массива:");
    Console.Write("Строк - ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Столбцов - ");
    int col = int.Parse(Console.ReadLine());
    while (col==row)
    {
        Console.WriteLine("По условию матрица прямоуголная. Кол-во столбцов не должно быть равно кол-ву строк!");
        Console.Write("Столбцов - ");
        col = int.Parse(Console.ReadLine());
    }
    Random elem = new Random();
    int[,] array = new int[row,col];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = elem.Next(0,50);
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
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FindMinSum(int[,] array)
{
    int minI = 0;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum +=array[minI,j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(sum < minSum)
        {
            minSum = sum;
            minI = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - {minI}, Сумма элементов - {minSum}");
}


int[,] array = CreateArray();

PrintArray(array);

FindMinSum(array);