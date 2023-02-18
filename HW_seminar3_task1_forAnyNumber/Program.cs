// Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом. Проверка без применения строк

// 14212 -> нет

// 12821 -> да

// 23432 -> да

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

bool ValidateNumber(int anyNumber)
{
  if (anyNumber >= 10)
  {
    return true;
  }
  System.Console.WriteLine("Введенное вами число не является положительным целым числом больше 10.");
  return false;
}

int getInvertedNumber(int inputNumber)
{
  int invertedNumber = 0;
  while(inputNumber > 0)
  {
    invertedNumber = invertedNumber * 10 + inputNumber % 10;
    inputNumber = inputNumber / 10;
  }
  return invertedNumber;
}

int number = InputInt("Введите положительное целое число больше 10 для проверки является ли оно палиндромом: ");

if (ValidateNumber(number))
{
  if(number == getInvertedNumber(number))
  {
    System.Console.Write($"Число {number} является палиндромом");
  }
  else
  {
    System.Console.Write($"Число {number} не является палиндромом");
  }
}
