// Задача 1:
//  Напишите цикл, который принимает на вход два числа (A и B) и
//   возводит число A в натуральную степень B (и в нулевую степень). 
// Использовать свои функции, не использовать Math.Pow
System.Console.WriteLine("Hello, friend! This cucle accept in input two numbers A and B and then reach A in the degree B.");
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int A = Prompt("Please, add a number A ---> ");
int B = Prompt("Please, add a degree B ---> ");
System.Console.WriteLine("Great!");
System.Console.WriteLine("Calculating......");
int GetCount( string message)
{
int result=A;
for(int i=0; i < (B-1); i++ )
{
 result=result*A;
}
    return result;
}
System.Console.WriteLine($"Result ----> {GetCount($"Count:")}");