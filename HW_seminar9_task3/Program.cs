// Задача 3: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29


int InputNumber(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToInt32(Console.ReadLine());
}


int CountFunctionAkkerman(int numFirst, int numSecond)
{
  if (numFirst == 0) return numSecond + 1;
  if (numFirst > 0 && numSecond == 0) return CountFunctionAkkerman(numFirst - 1, 1);
  return CountFunctionAkkerman(numFirst - 1, CountFunctionAkkerman(numFirst, numSecond - 1));
}

int numberFirst = InputNumber("Введите первое число больше или равное нулю ");
int numberSecond = InputNumber("Введите второе число больше или равное нулю ");
System.Console.WriteLine($"Функция Аккермана для двух чисел A({numberFirst},{numberSecond}) = {CountFunctionAkkerman(numberFirst, numberSecond)}");