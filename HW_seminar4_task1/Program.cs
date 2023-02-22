// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string message)
{
  System.Console.Write($"{message} ");
  int value;
  bool isCorrect = int.TryParse(Console.ReadLine(), out value);
  if (isCorrect)
  {
    return value;
  }
  System.Console.WriteLine("Вы ввели не число или не целое число");
  Environment.Exit(1);
  return 0;
}

bool ValidateNumber(int naturalNumber)
{
  if (naturalNumber >= 1)
  {
    return true;
  }
  System.Console.WriteLine("Введенное вами число не является натуральным.");
  return false;
}

int GetNumberInPower(int number, int power)
{
  int result = number;
  for (int i = 1; i < power; i++)
  {
    result = result * number;
  }
  return result;
}

int number = InputInt("Введите целое число A, которое нужно возвести в степень: ");
int power = InputInt("Введите натуральное число B - степень, в которую нужно возвести число A: ");
if(ValidateNumber(power))
{
  System.Console.WriteLine($"При возведении числа {number} в степень {power} получается число {GetNumberInPower(number, power)}"); 
}