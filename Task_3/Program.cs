// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random_number(min, max);
        Console.Write($"\t{matrix[i, j]} ");
    }
    Console.WriteLine();
}

double[] average = new double[matrix.GetLength(1)];

for(int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    average[j] = sum / matrix.GetLength(0);
}

Console.WriteLine("\tСреднее арифметическое каждого столбца:");

for(int i = 0; i < matrix.GetLength(1); i++)
{
    Console.Write("\t{0:F2}", average[i]);
}


