// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

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

double distanceBetweenPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
  int deltaX = x2 - x1;
  int deltaY = y2 - y1;
  int deltaZ = z2 - z1;
  return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
}

int x1 = InputInt("Введите абсциссу первой точки A x1:");
int y1 = InputInt("Введите ординату первой точки A y1:");
int z1 = InputInt("Введите аппликату первой точки A z1:");
int x2 = InputInt("Введите абсциссу второй точки B x2");
int y2 = InputInt("Введите ординату второй точки B y2");
int z2 = InputInt("Введите аппликату второй точки B z2:");

double distanceCounted = distanceBetweenPoints(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между первой точкой A с координатами ({x1},{y1},{z1}) и второй точкой B с координатами ({x2},{y2},{z2}) равно {distanceCounted:F2}");
