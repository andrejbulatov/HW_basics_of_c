// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int minElement, int maxElement)
{
  int [] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minElement, maxElement + 1);
  }
  return array;
}

void PrintArray(int[] array)
{
  System.Console.Write("{ " );
  System.Console.Write($"{array[0]}");
  for (int i = 1; i < array.Length; i++)
  {
    System.Console.Write($", {array[i]}");
  }
  System.Console.Write(" }" );
  System.Console.WriteLine();
}

int SumElementsOnOddPositions(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i = i + 2)
  {
    sum = sum + array[i];
  }
  return sum;
}

int InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = InputData("Введите размер массива: ");
int minimalElement = InputData("Введите минимальный порог случайных значений в массиве: ");
int maximalElement = InputData("Введите максимальный порог случайных значений в массиве: ");
int [] array = FillArray(sizeArray, minimalElement, maximalElement);
PrintArray(array);
int sumElementsOnOddPosition = SumElementsOnOddPositions(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях (имеющих нечетные индексы) равна {sumElementsOnOddPosition}");
