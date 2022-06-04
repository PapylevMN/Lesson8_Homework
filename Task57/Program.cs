
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

bool RepeateCheck(int elemArray, int[] sample)
{
    for (int n = 0; n < sample.Length; n++)
    {
        if (sample[n] == elemArray) return true;
    }
    return false;
}

int [] CreateSample(int[,] array)
{
    int[] sample = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 1; i < sample.Length; i++)
    {
        sample[i] = -1;
    }
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            int elemSample = array[i,j];
            bool repeate = RepeateCheck(elemSample, sample);
            if (repeate) continue;
            else
            {
                sample[k] = elemSample;
                k+=1;
            }
        }
    }
    int count = 0;
    for (int i = 0; i < sample.Length; i++)
    {
        if (sample[i]!=-1) count += 1;
    }
    int[] res = new int[count];
    k = 0;
    for (int i = 0; i < sample.Length; i++)
    {
        if(sample[i] != -1) 
        {
            res[k] = sample[i];
            k += 1;
        }
    }
    return res;
}

void Dict(int[,] array)
{
    int[] sample = CreateSample(array); 

    for (int i = 0; i < sample.Length; i++)
    {
        Console.WriteLine($"Элемент {sample[i]} встречается {ElementCount(sample[i], array)} раз");     
    }
}

int ElementCount(int elemArray, int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == elemArray)
            {
                count +=1;
            }
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива:");
Console.Write("Строк - ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбцов - ");
int col = int.Parse(Console.ReadLine());

int[,] array = CreateArray(row, col);
PrintArray(array);
Dict(array);