// Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Input three numbers: ");

int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());

if (numA > numB && numA > numC) Console.WriteLine("max = " + numA);
else 
    if (numB > numA && numB > numC) Console.WriteLine("max = " + numB);
else 
    if (numC > numA && numC > numB) Console.WriteLine("max = " + numC);
else Console.WriteLine("The numbers are equal");