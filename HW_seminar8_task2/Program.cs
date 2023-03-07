// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


int[,] GenerateArray(int row, int col)
{
  int[,] array = new int[row, col];
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


void PrintArray(int[,] array)
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


int CountSumElementsArrayInRow(int[,] array, int row)
{
  int sumElementsRow = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    sumElementsRow = sumElementsRow + array[row, j];
  }
  return sumElementsRow;
}


int FindRowWithMinSum(int[,] array)
{
  int indexMinRow = 0;
  for (int i = 1; i < array.GetLength(0); i++)
  {
    if (CountSumElementsArrayInRow(array, i) < CountSumElementsArrayInRow(array, indexMinRow)) indexMinRow = i;
  }
  int rowMinSum = indexMinRow + 1;
  return rowMinSum;
}


int rows = InputData("Задайте число строк в двумерном массиве m: ");
int columns = InputData("Задайте число столбцов в двумерном массиве n: ");
int[,] matrix = GenerateArray(rows, columns);
PrintArray(matrix);
System.Console.WriteLine($"Строка с меньшей суммой элементов: {FindRowWithMinSum(matrix)}.");
