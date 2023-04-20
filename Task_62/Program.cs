/*
	Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
	Например, на выходе получается вот такой массив:
	01 02 03 04
	12 13 14 05
	11 16 15 06
	10 09 08 07
*/

Console.Clear();
Console.WriteLine("Введите размеры матрицы");

int rowsArray2D = ReadIntNumber("Количество строк: ");
int colsArray2D = ReadIntNumber("Количество столбцов: ");
int[,] array2D = FillArray2D(rowsArray2D, colsArray2D);
PrintArray2D(array2D);

int[,] FillArray2D(int rowsArray2DToFill, int colsArray2DToFill)
{
    int[,] fillArray = new int[rowsArray2DToFill, colsArray2DToFill];
    int k = 0;
    int num = 1;
    int finish = rowsArray2DToFill * colsArray2DToFill;
    int i, j;

    while (true)
    {
        // Горизонтально вправо
        i = k;
        for (j = k; j < colsArray2DToFill - k; j++)
        {
            fillArray[i, j] = num;
            num++;
            if (num > finish) return fillArray;
        }
        // Вертикально вниз
        j = colsArray2DToFill - k - 1;
        for (i = 1 + k; i < rowsArray2DToFill - k; i++)
        {
            fillArray[i, j] = num;
            num++;
            if (num > finish) return fillArray;
        }
        // Горизонтально влево
        i = rowsArray2DToFill - k - 1;
        for (j = colsArray2DToFill - k - 2; j > k - 1; j--)
        {
            fillArray[i, j] = num;
            num++;
            if (num > finish) return fillArray;
        }
        // Вертикально вверх
        j = k;
        for (i = rowsArray2DToFill - 2 - k; i > k; i--)
        {
            fillArray[i, j] = num;
            num++;
            if (num > finish) return fillArray;
        }
        k++;
    }
}

int ReadIntNumber(string msg)
{
    if (msg != "") Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray2D(int[,] array2DForPrint)
{
    // Посчитаем сколько цифр в самом большом числе массива
    int countDigit = ((int)Math.Log10(array2DForPrint.Length) + 1);
    // Создадим переменную, которая добавит нули к числам
    string countString = "D" + countDigit.ToString();
    for (int i = 0; i < array2DForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < array2DForPrint.GetLength(1); j++)
        {
            Console.Write($"{array2DForPrint[i, j].ToString(countString)} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

