// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int Prompt(string message)
{
  System.Console.Write($"{message}: ");
  return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int number)
{
  if (number >=100 && number < 1000)
  {
    return true;
  }
  System.Console.WriteLine("Введенное вами число не является трехзначным.");
  return false;
}

int numberInput = Prompt("Введите трехзначное число");
if (Validate(numberInput))
{
  int secondDigit = numberInput / 10 % 10;
  System.Console.WriteLine($"Вторая цифра трехзначного числа {numberInput} равна {secondDigit}.");
}