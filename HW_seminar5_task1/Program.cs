// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
  int [] array = new int[size];
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(100, 1000);
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

int CountEvenNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] % 2 == 0) count++;
  }
  return count;
}

int InputData(string prompt)
{
  System.Console.WriteLine($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = InputData("Введите размер массива: ");
int [] array = FillArray(sizeArray);
PrintArray(array);
int count = CountEvenNumbers(array);
System.Console.WriteLine($"Количество четных чисел в массиве равно {count}");
