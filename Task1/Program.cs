//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа");
string input1 = Console.ReadLine()!;
string input2 = Console.ReadLine()!;
int parseInput1 = int.Parse(input1);
int parseInput2 = int.Parse(input2);
if (parseInput1 > parseInput2)
{
    Console.WriteLine("max = " + parseInput1);
    Console.WriteLine("min = " + parseInput2);
}
else
{
    Console.WriteLine("max = " + parseInput2);
    Console.WriteLine("min = " + parseInput1);
}