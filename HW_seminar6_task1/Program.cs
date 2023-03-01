// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double[] FillArray(int size)
{
  double [] array = new double[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = InputData($"Введите {i + 1} элемент массива: ");
  }
  return array;
}

void PrintArray(double[] array)
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
double InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToDouble(Console.ReadLine());
}
int InputSize(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}

int FindPositiveElementsArray(double[] array)
{ int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0)
    {
      count++;
    }
  }
  return count;
}

int number = InputSize("Введите число M - количество цифр, которое будет участвовать в определении числа положительных элементов: ");
double[] array = FillArray(number);
PrintArray(array);
System.Console.WriteLine($"Количество положительных цифр в ряду {FindPositiveElementsArray(array)}");
