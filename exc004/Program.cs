// Напишите программу,
// которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Input number: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 10);