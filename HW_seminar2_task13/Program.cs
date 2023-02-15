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

int numberInput = Prompt("Введите число");
int numberOutput = numberInput;
int thirdDigit = 0;
if (Validate(numberInput))
{
  while (numberInput > 100)
  {
    thirdDigit = numberInput % 10;
    numberInput = numberInput / 10;
  }
  System.Console.WriteLine($"Третья цифра числа {numberOutput} равна {thirdDigit}.");
}



