// // Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120






Console.Write("Введите натуральное число ");
int num = int.Parse(Console.ReadLine());

int GetNumbers (int number)                               // метод int  который что то возвращает
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}

int sumResult = GetNumbers (number);
Console.WriteLine($"Произведение чисел от 1 до {num} = {sumResult}");
