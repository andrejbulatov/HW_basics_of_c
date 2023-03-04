// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


double[,] GenerateArray(int row, int col)
{
  double[,] array = new double[row, col];
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
    }
  }
  return array;
}


void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    System.Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]:F1}\t");
    }
  }
  System.Console.WriteLine();
}


int rows = InputData("Задайте число строк в двумерном массиве m: ");
int columns = InputData("Задайте число столбцов в двумерном массиве n: ");
double[,] matrix = GenerateArray(rows, columns);
PrintArray(matrix);
