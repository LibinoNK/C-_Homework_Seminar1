//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое сравниваемое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе сравниваемое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    System.Console.WriteLine($"Первое число ({firstNum}) больше");
}
else
{
    System.Console.WriteLine($"Второе число ({secondNum}) больше");
}
