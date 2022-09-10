// Напишите программу, которая на вход принимает позиции (две) элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.


int random_number(int min, int max)
{
    int number = new Random().Next(min, max);
    return number;
}

Console.WriteLine("Задайте двумерный массив, введите количество строк и столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = random_number(min, max);
        Console.Write($"\t{matrix[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позиции искомого элемента, строку и столбец: ");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

if(row < matrix.GetLength(0) && column < matrix.GetLength(0))
{
    Console.Write($"Искомый элемент равен: {matrix[row, column]}");
}
else
{
    Console.Write($"Такого числа в массиве нет");
}
