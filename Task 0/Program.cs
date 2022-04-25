// Напишите программу, которая на вход принимает число и выдает его квадрвт (Число умноженное на само себя)

Console.Clear();
Console.Write("Введите целое число -> ");
int num = int.Parse(Console.ReadLine());
int numResult = num * num;
Console.Write("Квадрат числа равен -> ");
Console.WriteLine(numResult);
Console.ReadKey();
