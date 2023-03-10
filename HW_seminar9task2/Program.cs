// Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int InputNumber(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


int SumNumbersBetweenTwoNumbers(int numFirst, int numSecond)
{
  if (numSecond < numFirst)
  {
    return 0;
  }
  return numSecond + SumNumbersBetweenTwoNumbers(numFirst, numSecond - 1);
}


int numberFirst = InputNumber("Введите первое число ");
int numberSecond = InputNumber("Введите второе число ");
System.Console.WriteLine($"Сумма чисел в промежутке от {numberFirst} до {numberSecond} равна {SumNumbersBetweenTwoNumbers(numberFirst, numberSecond)}");
