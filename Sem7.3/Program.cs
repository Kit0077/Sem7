int[,] GetArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1, 7);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void average(int[,] arr)
{
    
    int count = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        count++;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        Console.WriteLine($"Ср.арифметическое столбца №{count} = {sum / arr.GetLength(0)}");
    }
    
}

int[,] array = GetArray(3, 5);
PrintArray(array);
average(array);
