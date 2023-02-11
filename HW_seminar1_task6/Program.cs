// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число для определения его четности: ");
string numberA = Console.ReadLine();
int number = Convert.ToInt32(numberA);

int remainderDivision = number % 2;

if (remainderDivision == 0)
{
  System.Console.WriteLine($"Число {number} является четным");
}
else
{
  System.Console.WriteLine($"Число {number} является нечетным");
}
