// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,] GenerateArray(int row, int col)
{
  double[,] array = new double [row, col];
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(1, 10);
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
      System.Console.Write($"{array[i, j]}\t");
    }
  }
  System.Console.WriteLine();
}


double averageValueColumn(double[,] array, int col)
{
  double sumElement = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    sumElement = sumElement + array[i, col];
  }
  return sumElement / (array.GetLength(0));
}

void PrintResultAverageColumn(double[,] array)
{
  System.Console.Write("Среднее арифметическое каждого столбца: ");
  System.Console.Write($"{averageValueColumn(array, 0):F1}");
  for (int j = 1; j < array.GetLength(1); j++)
  {
    System.Console.Write($"; {averageValueColumn(array, j):F1}");
  }
  System.Console.Write(".");
}


double[,] matrix = GenerateArray(3, 4);
PrintArray(matrix);
PrintResultAverageColumn(matrix);

