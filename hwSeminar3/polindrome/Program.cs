// Задача 1: 
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
System.Console.WriteLine("Program accept the five value of number and cheking if this number is a polindrome number. ");

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int polindrome = Prompt("Please, Enter a five-digit number ---> ");

bool ValidateNumber(int polindrome)
{
int Count = 0;
int A = polindrome;
while (A>0)
{
   A = A / 10;
   Count = Count + 1;
}
if (Count != 5)
{
    System.Console.WriteLine("You did not enter a five-digit number. Try again, Friend!");
    return false;
}
return true;
}

bool PolindromCheck(int polindrome)
{
int A = polindrome;
int Div = A / 1000;
System.Console.WriteLine(Div);
int Rem1 = A % 10;
int Rem2 = A/10 % 10;
int Rem = Rem1 * 10 + Rem2;
System.Console.WriteLine(Rem);
if ( Div == Rem)
{
    System.Console.WriteLine($"Great! Number {A} is a polindrome.");
    return true;
}
System.Console.WriteLine($"Number {A} is not a polindrome.");
return false;
}
if (!ValidateNumber(polindrome))
{
    return;
}

System.Console.WriteLine($"{PolindromCheck(polindrome)}");