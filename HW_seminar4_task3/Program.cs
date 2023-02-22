// Задача 29: 
// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int size, int minElement, int maxElement)
{
  int [] array = new int[size];
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(minElement, maxElement + 1);
  }
  return array;
}

void PrintArray(int[] array)
{
  System.Console.Write($"{array[0]}");
  for (int i = 1; i < array.Length; i++)
  {
    System.Console.Write($", {array[i]}");
  }
  System.Console.WriteLine();
}

int InputData(string prompt)
{
  System.Console.WriteLine($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = InputData("Введите размер массива: ");
int minimalElement = InputData("Введите минимальный порог случайных значений в массиве: ");
int maximalElement = InputData("Введите максимальный порог случайных значений в массиве: ");
int [] array = FillArray(sizeArray, minimalElement, maximalElement);
PrintArray(array);
