/*
	Задача 58: Задайте две матрицы. Напишите программу, 
	которая будет находить произведение двух матриц.
	Например, даны 2 матрицы:
	2 4 | 3 4
	3 2 | 3 3
	
	Результирующая матрица будет:
	18 20
	15 18
*/

Console.Clear();
Console.WriteLine("Введите первую матрицы");
int rowsOneMatrix = ReadIntNumber("Введите количество строк: ");
int colsOneMatrix = ReadIntNumber("Введите количество столбцов: ");
int[,] oneMatrix = FillArray2D(rowsOneMatrix, colsOneMatrix, 1, 9);

Console.WriteLine("Введите вторую матрицы");
int rowsTwoMatrix = ReadIntNumber("Введите количество строк: ");
int colsTwoMatrix = ReadIntNumber("Введите количество столбцов: ");
int[,] twoMatrix = FillArray2D(rowsTwoMatrix, colsTwoMatrix, 1, 9);


PrintArray2D(oneMatrix);
PrintArray2D(twoMatrix);

if (rowsOneMatrix == colsTwoMatrix)
{
    int[,] multiMatrix = MultiplicationMatix(oneMatrix, twoMatrix);
    Console.WriteLine("Произведение двух матриц:");
    PrintArray2D(multiMatrix);
}
else
{
    Console.WriteLine("Такие матрицы умножать нельзя");
}

int[,] MultiplicationMatix(int[,] oneMatrixForMulti, int[,] twoMatrixForMulti)
{
    int[,] multiMatrix = new int[oneMatrixForMulti.GetLength(0), twoMatrixForMulti.GetLength(1)];
    for (int i = 0; i < oneMatrixForMulti.GetLength(0); i++)
    {
        for (int j = 0; j < twoMatrixForMulti.GetLength(1); j++)
        {
            for (int k = 0; k < twoMatrixForMulti.GetLength(0); k++)
            {
                multiMatrix[i, j] += oneMatrixForMulti[i, k] * twoMatrixForMulti[k, j];
            }
        }
    }
    return multiMatrix;
}

int ReadIntNumber(string msg)
{
    if (msg != "") Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
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

void PrintArray2D(int[,] array2DForPrint)
{
    for (int i = 0; i < array2DForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < array2DForPrint.GetLength(1); j++)
        {
            Console.Write($"{array2DForPrint[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}