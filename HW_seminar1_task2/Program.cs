// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число для сравнения: ");
string numberA = Console.ReadLine();
int numberFirst = Convert.ToInt32(numberA);

System.Console.Write("Введите второе число для сравнения: ");
string numberB = Console.ReadLine();
int numberSecond = Convert.ToInt32(numberB);

if (numberFirst == numberSecond)
{
  System.Console.WriteLine($"Вы ввели одинаковые цифры {numberFirst} два раза, введите разные цифры для сравнения");
}
if (numberFirst > numberSecond)
{
  System.Console.WriteLine($"Максимальное значение max={numberFirst}, минимальное значение min={numberSecond}");
}
if (numberFirst < numberSecond)
{
  System.Console.WriteLine($"Максимальное значение max={numberSecond}, минимальное значение min={numberFirst}");
}



