Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.
System.Console.WriteLine("Введите трехзначное число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 99 & N < 1000)
{
    int H = N/10 % 10;
    System.Console.WriteLine($"Ваше число {N}. Вторая цифра {H}!");
}
else
{
   System.Console.WriteLine("Вы ввели не трехзначное число! Введите корректные значения!"); 
}