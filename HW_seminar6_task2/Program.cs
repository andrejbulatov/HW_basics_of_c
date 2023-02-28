// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double InputData(string prompt)
{
  System.Console.Write($"{prompt}");
  return Convert.ToDouble(Console.ReadLine());
}

bool CheckParallelLines(double firstCoefficient, double secondCoefficient)
{
  if(firstCoefficient == secondCoefficient)
  {
    return true;
  }
  return false;
}

double[] FindCoordinatesIntersectionOfLines(double angleCoefFirst, double freeCoefFirst, double angleCoefSecond, double freeCoefSecond)
{
  double[] pairCoordinates = new double[2];
  pairCoordinates[0] = (freeCoefSecond-freeCoefFirst) / (angleCoefFirst-angleCoefSecond);
  pairCoordinates[1] = angleCoefFirst * pairCoordinates[0] + freeCoefFirst;
  return pairCoordinates;
}
void PrintCoordinatesPair(double[] array)
{
  System.Console.Write("(" );
  System.Console.Write($"{array[0]:F2}");
  System.Console.Write($"; {array[1]:F2}");
  System.Console.Write(")" );
}

System.Console.WriteLine("Уравнение прямой имеет вид: y = k*x + b");
double slopeFirst = InputData("Введите угловой коэффициент первой прямой k1: ");
double freeCoefficientFirst = InputData("Введите свободный коэффициент первой прямой b1: ");
double slopeSecond = InputData("Введите угловой коэффициент второй прямой k2: ");
double freeCoefficientSecond = InputData("Введите свободный коэффициент второй прямой b2: ");
if(CheckParallelLines(slopeFirst, slopeSecond) == true)
{
  System.Console.WriteLine("Прямые параллельные, они не имеют точек пересечения.");
}
else
{
  double[] pairCoord = FindCoordinatesIntersectionOfLines(slopeFirst, freeCoefficientFirst, slopeSecond, freeCoefficientSecond);
  System.Console.Write("Координаты точки пересечения прямых: ");
  PrintCoordinatesPair(pairCoord);
}
