
int[,] CreateArray(int a, int b)
{
    Random elem = new Random();
    int[,] array = new int[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i,j] = elem.Next(0,10);
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
    Console.WriteLine();
}

void PrintResult(int[,] array)
{
    int[] temp = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[j] = array[i,j];
        }
        Array.Sort(temp);
        Array.Reverse(temp);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = temp[j];
        }
    }
    PrintArray(array);
}

Console.WriteLine("Введите размер массива:");
Console.Write("Строк - ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбцов - ");
int col = int.Parse(Console.ReadLine());

int[,] array = CreateArray(row, col);
PrintArray(array);
PrintResult(array);