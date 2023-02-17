// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
  System.Console.Write($"{message}: ");
  return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int number)
{
  if (number >= 100)
  {
    return true;
  }
  System.Console.WriteLine("Введенное вами число не имеет третьей цифры.");
  return false;
}
int thirdDigit = 0;
int GetThirdDigitOfNumber(int anyNumber)
{
  while (anyNumber > 100)
  { 
    thirdDigit = anyNumber % 10;
    anyNumber = anyNumber / 10;
  }
  return thirdDigit;
}

int numberInput = Prompt("Введите число");
int numberOutput = numberInput;

if (Validate(numberInput))
{
  System.Console.WriteLine($"Третья цифра числа {numberOutput} равна {GetThirdDigitOfNumber(numberInput)}.");
}



