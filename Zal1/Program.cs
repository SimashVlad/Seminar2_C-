Console.Write("Введите число a ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число b ");
int num2 = int.Parse(Console.ReadLine());
//Console.Write("Квадрат числа равен -> ");
int numResult = num1 * num1;
if (numResult == num2)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
//Console.WriteLine(numResult);
Console.ReadKey();