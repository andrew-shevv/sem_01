// Напишите программу,
// которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Input three-digit number: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000) Console.WriteLine(num % 10);
else Console.WriteLine("This number doesn't have three digits");