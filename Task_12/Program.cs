
int number1 = new Random().Next(10, 100);
int number2 = new Random().Next(10, 100);
Console.WriteLine($"первое число = {number1}");
Console.WriteLine($"второе число = {number2}");
int result = number1 % number2;
if(number1 > number2)
{
    if (result == 0)
    {
        Console.WriteLine("Числа кратно");
    }
    else
    {
        Console.WriteLine($"Число не кратно, остаток = {result}");
    }
}
else 
{
    Console.WriteLine("Число не делится");
}