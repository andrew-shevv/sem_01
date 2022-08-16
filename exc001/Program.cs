// Напишите программу, 
// которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

Console.WriteLine("Input two numbers: ");

int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Is the first number the square of the second number?");

if (numA == numB * numB)
{
    Console.WriteLine("yes");
}
else Console.WriteLine("no");