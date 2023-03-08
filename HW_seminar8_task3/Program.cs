// Задача 3 * : Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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


bool Validate(int[,] arrayFirst, int[,] arraySecond)
{
  if (arrayFirst.GetLength(1) == arraySecond.GetLength(0))
  {
    return true;
  }
  System.Console.WriteLine($"Введите корректные данные. Для перемножения матриц число столбцов в первом массиве" 
                           +" должно быть равно числу строк во втором массиве n1=m2");
  return false;
}


int[,] MultiplicateArray(int[,] arrayFirst, int[,] arraySecond)
{
  int[,] result = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sumMultipliedElement = 0;
      for (int k = 0; k < arrayFirst.GetLength(1); k++)
      {
        sumMultipliedElement = sumMultipliedElement + arrayFirst[i, k] * arraySecond[k, j];
      }
      result[i, j] = sumMultipliedElement;
    }
  }
  return result;
}



int rowsFirst = InputData("Задайте число строк в первом двумерном массиве m1: ");
int columnsFirst = InputData("Задайте число столбцов в первом двумерном массиве n1: ");
int rowsSecond = InputData("Задайте число строк во втором двумерном массиве m2: ");
int columnsSecond = InputData("Задайте число столбцов во втором двумерном массиве n2: ");
int[,] matrixFirst = GenerateArray(rowsFirst, columnsFirst);
int[,] matrixSecond = GenerateArray(rowsSecond, columnsSecond);
PrintArray(matrixFirst);
PrintArray(matrixSecond);
if(Validate(matrixFirst, matrixSecond)) PrintArray(MultiplicateArray(matrixFirst, matrixSecond));

