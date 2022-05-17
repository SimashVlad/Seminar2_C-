// 
Console.WriteLine("Введите число дня недели от 1 до 7: ");
var day = Convert.ToInt32(Console.ReadLine());
string[] isWeekend = {"нет", "нет", "нет", "нет", "нет", "нет", "да", "да"};
if(day > 0 && day < 8)
{
    Console.WriteLine(isWeekend[day -1]);
}
else Console.WriteLine("Вы ввели некорректное значение!");
