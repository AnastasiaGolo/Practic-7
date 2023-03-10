//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4


int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

ShowArray();

Console.WriteLine("Введите столбец: ");
int lineNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку: ");
int positionNumber = Convert.ToInt32(Console.ReadLine());

PrintNuberByIndex(lineNumber, positionNumber);

void PrintNuberByIndex(int lineNumber, int positionNumber)
{
 if (array.GetLength(0) > lineNumber && array.GetLength(1) > positionNumber)
    {
 Console.WriteLine(array[lineNumber, positionNumber]);
    }
 else
    {
 Console.WriteLine("Такого числа в массиве нет");
    }
}

void ShowArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}