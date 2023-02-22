// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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

bool ValidateNumber(int positiveNumber)
{
  if (positiveNumber >= 0)
  {
    return true;
  }
  System.Console.WriteLine("Введенное вами число не является положительным или нулем.");
  return false;
}

int GetSumOfDigits(int number)
{
  int sum = 0;
  while(number > 0)
  {
    sum = sum + number % 10;
    number = number / 10;
  }
  return sum;
}

int number = InputInt("Введите положительное целое число или ноль для подсчета суммы цифр в числе: ");
if(ValidateNumber(number))
{
  System.Console.WriteLine($"Сумма цифр в числе {number} равна {GetSumOfDigits(number)}");
}


