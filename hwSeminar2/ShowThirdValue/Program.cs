Console.WriteLine("Hello, Friend!");
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
System.Console.WriteLine("Программу выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
System.Console.WriteLine("Введите значение:");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Прекрасно!");
int Count = 0;
int A = N;
while (A > 0)
{
   A = A / 10;
   Count = Count + 1;
}
if (Count <= 2)
{
   System.Console.WriteLine("Третьей цифры нет. Очень жаль! Попытайтесь еще раз =)");
}
else
{
int I = Convert.ToInt32(Math.Pow(10,(Count-3)));
int V = N / I;
int Third = V % 10;
System.Console.WriteLine($"Третья цифра числа {N} --> {Third}!");
}