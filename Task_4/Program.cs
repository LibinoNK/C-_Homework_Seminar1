//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое сравниваемое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе сравниваемое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье сравниваемое число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (firstNum > secondNum)
{
   max = firstNum;
}
else
{
    max = secondNum;
}

if (max > thirdNum)
{
    System.Console.WriteLine($"Большее число: {max}");
}
else
{
    System.Console.WriteLine($"Большее число: {thirdNum}");
}