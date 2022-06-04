
int[,] CreateArray(int n)
{
    Random elem = new Random();
    int[,] array = new int[n,n];
    
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
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

int[,] MatrixMult(int[,] array1, int[,] array2)
{
    int n = array1.GetLength(1);
    int[,] res = new int[n,n];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        int row = 0;
        while (row < array2.GetLength(1))
        {
            int sum = 0;
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                sum += (array1[i,j]*array2[j,row]);
            }
            res[i,row] = sum;
            row += 1;
        }
    }
    return res;
}

Console.Write("Введите размер квадратного массива:");
int row = int.Parse(Console.ReadLine());
int[,] multcand = CreateArray(row);
int[,] multlier = CreateArray(row);

PrintArray(multcand);
PrintArray(multlier);

int[,] result= MatrixMult(multcand, multlier);
Console.WriteLine("Произведение матриц:");
PrintArray(result);