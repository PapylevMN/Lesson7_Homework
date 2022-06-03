
int[,] CreateArray(int a, int b)
{
    Random elem = new Random();
    int[,] array = new int[a,b];
    
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
        array[i,j] = elem.Next(0,100);
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

void SearchElement(int[,] array)
{
    Console.Write("Введите позицию искомого элемента:");
    int pos = int.Parse(Console.ReadLine());
    int i = pos/10;
    int j = pos%10;
    if (i >= array.GetLength(0) | j >= array.GetLength(1)) 
    {
        Console.WriteLine("Некорректный ввод позиции!");
    }
    else
    {
        Console.WriteLine($"Искомый елемент - {array[i,j]}");
    }
}

Console.WriteLine("Введите размер массива:");
Console.Write("Строк - ");
int row = int.Parse(Console.ReadLine());
Console.Write("Столбцов - ");
int col = int.Parse(Console.ReadLine());

int[,] array = CreateArray(row, col);

PrintArray(array);

SearchElement(array);