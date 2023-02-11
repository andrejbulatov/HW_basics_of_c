// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число N: ");
string numberN = Console.ReadLine();
int number = Convert.ToInt32(numberN);

int count = 2;

if (number <= 1)
{
  System.Console.WriteLine($"Вы ввели некорректное значение числа N = {number}. Для вывода всех четных чисел от 1 до N, N должно быть больше 1");
}

System.Console.Write($"Все четные числа от 1 до {number}: ");
while (count <= number)
{
  System.Console.Write($"{count} ");
  count = count + 2;
}
