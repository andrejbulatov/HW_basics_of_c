// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


int[,] GenerateArray(int row, int col)
{
  int[,] array = new int [row, col];
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


bool Validate(int[,] array, int positionRowElement, int positionColElement)
{
  if (positionRowElement - 1 >= 0
     && positionRowElement - 1 < array.GetLength(0)
     && positionColElement - 1 >= 0
     && positionColElement - 1 < array.GetLength(1))
  {
    return true;
  }
  System.Console.WriteLine($"Введенного вами элемента a[{positionRowElement}, {positionColElement}] в двумерном массиве нет");
  return false;
}

int positionRow = InputData("Задайте позицию строки искомого элемента в двумерном массиве i: ");
int positionColumn = InputData("Задайте позицию столбца искомого элемента в двумерном массиве j: ");
int[,] matrix = GenerateArray(3, 4);
PrintArray(matrix);
if(Validate(matrix, positionRow, positionColumn))
{
  System.Console.WriteLine($"Вы ввели позицию элемента массива a[{positionRow}, {positionColumn}] = {matrix[positionRow - 1, positionColumn - 1]}");
}