bool RepeateCheck(int elemArray, int[,,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                if (array[n,i,j] == elemArray)
                {
                    goto Metka;
                }
            }
        }
    }
    return true;

    Metka:
    return false;
}

int[,,] CreateArray(int z, int x, int y)
{
    Random elem = new Random();
    int[,,] array = new int[z, x, y];
    
    for (int n = 0; n < z; n++)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                bool flag = true;
                while (flag)
                {
                    int elemArray = elem.Next(10,100);
                    bool res = RepeateCheck(elemArray, array);
                    if (res)
                    {
                        array[n, i, j] = elemArray;
                        flag = false;
                    }
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"({n},{i},{j}) {array[n,i,j]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер трехмерного массива:");
Console.Write("Количество таблиц - ");
int quont = int.Parse(Console.ReadLine());
Console.Write("Строк в таблице- ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбцов в таблице- ");
int col = int.Parse(Console.ReadLine());

int[,,] array = CreateArray(quont, row, col);
PrintArray(array);