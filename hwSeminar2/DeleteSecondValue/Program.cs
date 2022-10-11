Console.WriteLine("Hello, World!");
//  Напишите программу, которая выводит случайное трёхзначное число 
//  и удаляет вторую цифру этого числа. 
System.Console.WriteLine( " Программа выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");
int rnd = new Random().Next(99, 1000);
System.Console.WriteLine($"Рандомное число в диапозоне от 99 до 1000 --> {rnd}");
int N3 = rnd / 10 / 10;
int H = rnd % 10;
System.Console.WriteLine($"{N3}{H}");