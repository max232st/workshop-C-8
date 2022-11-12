// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Main()
{
    Console.Clear();
    Console.Write("Введите размер массива: ");
    int rows = int.Parse(Console.ReadLine());
    int columns = rows;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("");
    SumMinRowArray(array);
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SumMinRowArray(int[,] array)
{
    int minSumm = 0;
    int summ = 0;
    int minRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        if (i == 0)
        {
            minSumm = summ;
        }
        else if (summ < minSumm)
        {
            minSumm = summ;
            minRow = i;
        }
    }
    Console.WriteLine($"{minRow + 1} строка  с минимальной суммой элементов = {minSumm}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Main();