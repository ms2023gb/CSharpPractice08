/*
    Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2

    Результат:
    66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
    34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

Console.Clear();
int rowsArray3D = ReadIntNumber("Введите длину 1-го измерения: ");
int colsArray3D = ReadIntNumber("Введите длину 2-го измерения: ");
int depArray3D = ReadIntNumber("Введите длину 3-го измерения: ");

if (rowsArray3D * colsArray3D * depArray3D > 90)
{
    Console.WriteLine("Массив не возможно заполнить двузначными неповторяющимися числами");
}
else
{
    int[,,] array3D = FillArray3D(rowsArray3D, colsArray3D, depArray3D);
    PrintArray3D(array3D);
}

int[,,] FillArray3D(int rowsArray3DForFill, int colsArray3DForFill, int depArray3DForFill)
{
    int[,,] array3DForFill = new int[rowsArray3DForFill, colsArray3DForFill, depArray3DForFill];
    int startFillNumber = 10;
    for (int i = 0; i < array3DForFill.GetLength(0); i++)
    {
        for (int j = 0; j < array3DForFill.GetLength(1); j++)
        {
            for (int k = 0; k < array3DForFill.GetLength(2); k++)
            {
                array3DForFill[i, j, k] = startFillNumber;
                startFillNumber++;
            }
        }
    }
    return array3DForFill;
}

void PrintArray3D(int[,,] array3DForPrint)
{
    for (int i = 0; i < array3DForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < array3DForPrint.GetLength(1); j++)
        {
            for (int k = 0; k < array3DForPrint.GetLength(2); k++)
            {
                Console.Write($"{array3DForPrint[i, j, k]}({i},{j},{k}) "); ;
            }
        }
        Console.WriteLine();
    }
}

int ReadIntNumber(string msg)
{
    if (msg != "") Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()!);
}