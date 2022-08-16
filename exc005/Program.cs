// Напишите программу,
// которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input two numbers: ");

int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB) Console.WriteLine("max = " + numA);
else 
    if (numB > numA) Console.WriteLine("max = " + numB);
else Console.WriteLine("The numbers are equal");
