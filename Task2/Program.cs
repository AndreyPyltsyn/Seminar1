//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа");
string input1 = Console.ReadLine()!;
string input2 = Console.ReadLine()!;
string input3 = Console.ReadLine()!;
int parseInput1 = int.Parse(input1);
int parseInput2 = int.Parse(input2);
int parseInput3 = int.Parse(input3);
if (parseInput1 > parseInput2)
{
    if (parseInput1 > parseInput3)
    {
        Console.WriteLine("Максимальное число = " + parseInput1);
    }

    else
    {
        Console.WriteLine("Максимальное число = " + parseInput3);
    }
}
else if (parseInput2 > parseInput3)
{
    Console.WriteLine("Максимальное число = " + parseInput2);
}
else
{
    Console.WriteLine("Максимальное число = " + parseInput3);
}