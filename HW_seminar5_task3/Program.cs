// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{
  double [] array = new double[size];
  for (int i = 0; i < array.Length; i++)
  {
    int randomNumber = new Random().Next(1, 100);
    double number = Convert.ToDouble(randomNumber);
    array[i] = number + new Random().NextDouble();
  }
  return array;
}

void PrintArray(double[] array)
{
  System.Console.Write("{ " );
  System.Console.Write($"{array[0]:F2}");
  for (int i = 1; i < array.Length; i++)
  {
    System.Console.Write($", {array[i]:F2}");
  }
  System.Console.Write(" }" );
  System.Console.WriteLine();
}

double SearchMaxElement(double[] array)
{
  double maxElement = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if(maxElement < array[i]) maxElement = array[i];
  }
  return maxElement;
}

double SearchMinElement(double[] array)
{
  double minElement = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if(minElement > array[i]) minElement = array[i];
  }
  return minElement;
}

int InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = InputData("Введите размер массива: ");
double [] array = FillArray(sizeArray);
PrintArray(array);
double minElementArray = SearchMinElement(array);
double maxElementArray = SearchMaxElement(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {(maxElementArray - minElementArray):F2}");
