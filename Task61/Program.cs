
void PrintArray(int[,] array)
{
    int n = array.GetLength(0);
    string s;
    for (int i = 0; i < n; i++)
    {
        if (i < 5) s = new string(' ', n-i);
        else s = new string(' ', n-i-1);
        Console.Write(s);
        for (int j = 0; j < n; j++)
        {
            if (array[i,j] != 0) Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreatePascal(int n)
{
    int[,] temp = new int [n,n];
    temp[0,0] = 1;
    int i = 1;
    while (i < n)
    {
        for (int j = 0; j < i; j++)
        {   
            temp[i,j+1] = temp[i-1,j] + temp[i-1,j+1];
        }
        temp[i,0] = 1;
        i+=1;
    }
    return temp;
}

Console.Write("Введите желаемое количество строк треугольника Паскаля :");
int n = int.Parse(Console.ReadLine());
int[,] res = CreatePascal(n);
PrintArray(res);