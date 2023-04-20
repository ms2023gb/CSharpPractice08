/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int rows = 5;
int cols = 4;
int randomMin = 0;
int randomMax = 9;

int[,] array2D = FillArray2D(rows, cols, randomMin, randomMax);
PrintArray2D(array2D);

int minSumRowInArray2D = FindForArray2DMinSumRow(array2D);
Console.WriteLine();
Console.WriteLine($"{minSumRowInArray2D + 1} строка с минимальной суммой элементов");

int FindForArray2DMinSumRow(int[,] array2DToFind)
{
    int index = 0;
    int minSumRow = 0;
    for (int i = 0; i < array2DToFind.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array2DToFind.GetLength(1); j++)
        {
            sumRow += array2DToFind[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки - {sumRow}");
        if (i == 0)
        {
            minSumRow = sumRow;
        }
        else
        {
            if (minSumRow > sumRow)
            {
                minSumRow = sumRow;
                index = i;
            }
        }
    }
    return index;
}

void PrintArray2D(int[,] array2DForPrint)
{
    for (int i = 0; i < array2DForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < array2DForPrint.GetLength(1); j++)
        {
            Console.Write($"{array2DForPrint[i, j],2}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] FillArray2D(int fillRows, int fillCols, int fillRandomMin, int fillRandomMax)
{
    int[,] fillArray = new int[fillRows, fillCols];
    for (int i = 0; i < fillRows; i++)
    {
        for (int j = 0; j < fillCols; j++)
        {
            fillArray[i, j] = new Random().Next(fillRandomMin, fillRandomMax + 1);
        }
    }
    return fillArray;
}