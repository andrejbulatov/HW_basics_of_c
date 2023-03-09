// Задача 4 * : Напишите программу, которая заполнит спирально квадратный массив.


int InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


int[,] GenerateArray(int row, int col)
{
  int[,] array = new int[row, col];
  return array;
}


int[,] SpiralFillingArray(int[,] array)
{
  int valueElement = 1;
  int iBegin = 0;
  int iFinal = 0;
  int jBegin = 0;
  int jFinal = 0;
  int i = 0;
  int j = 0;
  while (valueElement <= array.GetLength(0) * array.GetLength(1))
  {
    array[i, j] = valueElement;
    if (i == iBegin && j < array.GetLength(1) - jFinal - 1) j++;
    else if (j == array.GetLength(1) - jBegin - 1 && i < array.GetLength(0) - iFinal - 1) i++;
    else if (i == array.GetLength(0) - iFinal - 1 && j > jBegin) j--;
    else i--;

    if ((i == iBegin + 1) && (j == jBegin) && (jBegin != array.GetLength(1) - jFinal - 1))
    {
      iBegin++;
      iFinal++;
      jBegin++;
      jFinal++;
    }
    valueElement++;
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



int rows = InputData("Задайте число строк в двумерном массиве m: ");
int columns = InputData("Задайте число столбцов в двумерном массиве n: ");
int[,] matrix = GenerateArray(rows, columns);
PrintArray(matrix);
PrintArray(SpiralFillingArray(matrix));