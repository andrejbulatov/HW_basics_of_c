// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputNumber(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


void ShowEvenNumbers(int numFirst, int numSecond)
{
  if (numFirst > numSecond)
  {
    return;
  }
  
  if (numFirst % 2 == 0) System.Console.WriteLine($"{numFirst}");
  ShowEvenNumbers(numFirst + 1, numSecond);
  
}


int numberFirst = InputNumber("Введите первое число ");
int numberSecond = InputNumber("Введите второе число ");
ShowEvenNumbers(numberFirst, numberSecond);