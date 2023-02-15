// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
  System.Console.Write($"{message}: ");
  return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int number)
{
  if (number >= 1 && number <= 7)
  {
    return true;
  }
  System.Console.WriteLine("Вы ввели некорректное значение номера дня недели. Номер дня недели может принимать значение от 1 до 7, где 1 - понедельник, 7 - воскресенье");
  return false;
}

int numberInput = Prompt("Введите номер дня недели");
string[] array = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

if (Validate(numberInput))
{
  if(numberInput == 6 || numberInput == 7)
  {
    System.Console.WriteLine($"Вы ввели номер дня недели {numberInput} - это {array[numberInput - 1]}, что соответствует выходному дню.");
  }
  else
  {
    System.Console.WriteLine($"Вы ввели номер дня недели {numberInput} - это {array[numberInput - 1]}, что соответствует не выходному дню.");
  }
}
