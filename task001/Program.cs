// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    ChangeRows(array);
    Console.WriteLine("Второй способ (количество строк и столбцов не имеет значения):");
    int[,] array2 = ChangeRows2(array);
    PrintArray(array2);
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

void ChangeRows(int[,] array)
{
    int rowLength = array.GetLength(0);
    int colLength = array.GetLength(1);
    if (rowLength == colLength)
    {

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = i + 1; j < colLength; j++)  // j начинается  с i+1 для того, чтобы обратно не поменять местами предыдущие строки
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
        Console.WriteLine("Первый способ:");
        PrintArray(array);
    }
    else Console.WriteLine("Первый способ: замена невозможна, т.к. количество строк и столбцов не совпадает.");
}

int[,] ChangeRows2(int[,] array)
{
    int rowLength = array.GetLength(0);
    int colLength = array.GetLength(1);
    int[,] newArray = new int[colLength, rowLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
}