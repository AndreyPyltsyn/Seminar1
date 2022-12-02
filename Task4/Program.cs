//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите числo");
string input = Console.ReadLine()!;
int parseInput = int.Parse(input);

for (int N = 1; N <= parseInput; N++)
{
    if (N % 2 == 0)
    {
        Console.WriteLine(N);
    }
}