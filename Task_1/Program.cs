// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными (тип double) числами.

double random_number(int min, int max)
{
    //int temp = ;
    double number = new Random().Next(min, max) + new Random().NextDouble();
    return number;
}


Console.WriteLine("Задайте двумерный массив, введите M и N: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());


double[,] matrix = new double[M, N];



for(int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for(int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        matrix[rows, columns] = random_number(min, max);
        Console.Write($"\t{matrix[rows, columns]} ");
    }
    Console.WriteLine();
}