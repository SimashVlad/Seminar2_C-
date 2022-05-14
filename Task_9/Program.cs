
int number = new Random().Next(10, 100);
int num1 = number / 10;
int num2 = number % 10;
Console.WriteLine(number);
Console.WriteLine($"первое число = {num1}");
Console.WriteLine($"второе число = {num2}");
Console.Write("максимальное число = ");
Console.WriteLine(num1 > num2 ? num1 : num2); // Краткая запись If Else
