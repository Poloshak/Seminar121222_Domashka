// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого числа в массиве нет

Console.Clear();
int[,] Array = new int [3,4];

GetArray(Array, -10, 10);
PrintArray(Array);

Console.Write("Введите номер строки массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца массива: ");
int columns=int.Parse(Console.ReadLine());
DoWeHaveThisElementInArray(Array, rows, columns);



void DoWeHaveThisElementInArray(int[,] arr, int row, int column)
{

    if (row <= arr.GetLength(0) && column <= arr.GetLength(1) && row>0 && column>0)
        Console.WriteLine(arr[row-1, column-1]);
    else Console.WriteLine("Такого элемента нет в массиве");
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}