int[,] GetArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1, 17);
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

void NumberFromArray(int m, int n, int[,] arr)
{
    
    if (m <= (arr.GetLength(0) - 1) && n <= (arr.GetLength(1) - 1))
    {
        Console.WriteLine($"Число из заданной позиции = {arr[m, n]}");
    }
    else Console.WriteLine("Элемента в такой позиции не существует");
}

Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, colums);
PrintArray(array);

Console.Write("Введите искомую строку: ");
int rows2 = int.Parse(Console.ReadLine());

Console.Write("Введите искомый столбец: ");
int colums2 = int.Parse(Console.ReadLine());

NumberFromArray(rows2, colums2, array);


