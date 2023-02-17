// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int InputInt(string message)
{
  System.Console.Write($"{message} ");
  int value;
  bool isCorrected = int.TryParse(Console.ReadLine(), out value);
  if (isCorrected)
  {
    return value;
  }
  System.Console.WriteLine("Вы ввели не число или не целое число.");
  Environment.Exit(1);
  return 0;
}

bool ValidateNumber(int anyNumber)
{
  if (anyNumber >= 1)
  {
    return true;
  }
  System.Console.WriteLine("Введенное вами число не является положительным целым числом.");
  return false;
}

int number = InputInt("Введите число N - положительное целое число, до которого необходимо выводить кубы чисел: ");

if (ValidateNumber(number))
{
  System.Console.Write($"Кубы чисел от 1 до {number} принимают следующие значения: ");
  for (int i = 1; i <= number; i++)
  {
    int cube = i * i * i;
    System.Console.Write($"{cube} ");
  }
}

