// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число для сравнения: ");
string numberA = Console.ReadLine();
int numberFirst = Convert.ToInt32(numberA);

System.Console.Write("Введите второе число для сравнения: ");
string numberB = Console.ReadLine();
int numberSecond = Convert.ToInt32(numberB);

System.Console.Write("Введите третье число для сравнения: ");
string numberC = Console.ReadLine();
int numberThird = Convert.ToInt32(numberC);

int maxNumber = numberFirst;

if (maxNumber < numberSecond)
{
  maxNumber = numberSecond;
}
if (maxNumber < numberThird)
  {
    maxNumber = numberThird;
  }

System.Console.WriteLine($"Максимальным числом из {numberFirst}, {numberSecond} и {numberThird} является {maxNumber}");
