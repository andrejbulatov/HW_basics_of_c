// Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.


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


int[,] SortInDecreaseElementsRowArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int numberForEnumeration = j + 1;
      while (numberForEnumeration < array.GetLength(1))
      {
        if (array[i, j] < array[i, numberForEnumeration])
        {
          (array[i, j], array[i, numberForEnumeration]) = (array[i, numberForEnumeration], array[i, j]);
        }
        numberForEnumeration++;
      }
    }
  }
  return array;
}


int rows = InputData("Задайте число строк в двумерном массиве m: ");
int columns = InputData("Задайте число столбцов в двумерном массиве n: ");
int[,] matrix = GenerateArray(rows, columns);
PrintArray(matrix);
PrintArray(SortInDecreaseElementsRowArray(matrix));
