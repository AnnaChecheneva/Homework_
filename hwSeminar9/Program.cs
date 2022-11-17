// Задача 1: 
// Задайте значения M и N. 
System.Console.WriteLine("Напишите программу, которая выведет все чётные натуральные числа");
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{   
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string OutPutEvenN(int a, int b)
{
    if (a > b) return string.Empty;
    if ( a % 2 == 0){}
    else { a = a + 1;}
    return $"{a} " + OutPutEvenN(a + 2, b); 
}
int a = Prompt("Enter a --->");
int b = Prompt("Enter b --->");
System.Console.WriteLine(OutPutEvenN(a, b));

// Задача 2: 
// Задайте значения M и N. 
 System.Console.WriteLine("Напишите программу, которая найдёт сумму натуральных элементов");
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int OutPutSum(int a, int b)
{
    if (a > b) return 0;
    else return a + OutPutSum(a + 1, b); 
}
int c = Prompt("Enter c --->");
int d = Prompt("Enter d --->");
System.Console.WriteLine(OutPutSum(c, d));

// Задача 3: 
System.Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии.");
//  Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29 

int Ackerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Ackerman(M - 1, 1);
    if (M > 0 && N > 0) return Ackerman(M - 1, Ackerman(M, N - 1));
return Ackerman(M, N);
}
int  M = Prompt("Enter c --->");
int N = Prompt("Enter d --->");

System.Console.WriteLine(Ackerman(M, N));