// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными (тип double) числами.

double random_number(int min, int max)
{
    double number = new Random().Next(min, max) + new Random().NextDouble();
    return number;
}


Console.WriteLine("Задайте двумерный массив, введите количество строк и столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());


double[,] matrix = new double[rows, columns];



for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random_number(min, max);
        Console.Write($"\t{matrix[i, j]} ");
    }
    Console.WriteLine();
}
