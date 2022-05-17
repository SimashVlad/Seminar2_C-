Console.WriteLine("Введите координаты точки A: ");
int numA1 = int.Parse(Console.ReadLine());
int numA2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int numB1 = int.Parse(Console.ReadLine());
int numB2 = int.Parse(Console.ReadLine());

int number1 = numA1 - numB1;
int number2 = numA2 - numB2;

double result = Math.Sqrt(number1 * number1 + number2 * number2);
Console.WriteLine($"Расстояние между точками =  {result}");