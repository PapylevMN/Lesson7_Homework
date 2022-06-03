double[,] CreateArray(int a, int b)
{
    Random elem = new Random();
    double[,] array = new double[a,b];
    
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i,j] = Convert.ToDouble(elem.Next(-100, 100)/10.0);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

Console.WriteLine("Введите размер массива:");
Console.Write("Строк - ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбцов - ");
int col = int.Parse(Console.ReadLine());

double[,] array = CreateArray(row, col);
PrintArray(array);