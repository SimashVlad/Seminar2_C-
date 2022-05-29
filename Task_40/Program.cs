// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите 1 число равной 1 длине треугольника");
int numbers1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число равной 2 длине треугольника");
int numbers2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 число равной 3 длине треугольника");
int numbers3 = int.Parse(Console.ReadLine());

if (numbers1 < numbers2 + numbers3
    && numbers2 < numbers1 + numbers3
    && numbers3 < numbers1 + numbers2)
{
    Console.WriteLine("треугольник может существовать с сторонами такой длины.");
}
else
{
    Console.WriteLine("треугольник не может существовать с сторонами такой длины.");
}