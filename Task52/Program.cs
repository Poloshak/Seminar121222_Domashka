// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




void ColumnArithmeticMean(int[,] inArray)
{
    
    for(int j=0; j<inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i= 0; i < inArray.GetLength(0); i++)
        {
            sum = sum + inArray[i,j];
        }
        Console.Write($"{(sum/inArray.GetLength(0)):f1}; ");
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t ");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());
int[,]Array = GetArray(rows,columns, -10, 10);
PrintArray(Array);
Console.WriteLine();
ColumnArithmeticMean(Array);
