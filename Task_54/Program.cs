/*
	Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
	Например, задан массив:

	1 4 7 2
	5 9 2 3
	8 4 2 4

	В итоге получается вот такой массив:

	7 4 2 1
	9 5 3 2
	8 4 4 2
*/

Console.Clear();

int rows = 4;
int cols = 5;
int randomMin = 0;
int randomMax = 9;

int[,] array2D = FillArray2D(rows, cols, randomMin, randomMax);
PrintArray2D(array2D);
BubbleSortRowsTable(array2D);
PrintArray2D(array2D);

void BubbleSortRowsTable(int[,] array2DForSort)
{
    for (int i = 0; i < array2DForSort.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < array2DForSort.GetLength(1); j++)
        {
            for (int k = j + 1; k < array2DForSort.GetLength(1); k++)
            {
                if (array2DForSort[i, j] < array2DForSort[i, k])
                {
                    temp = array2DForSort[i, j];
                    array2DForSort[i, j] = array2DForSort[i, k];
                    array2DForSort[i, k] = temp;
                }
            }
        }
    }
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