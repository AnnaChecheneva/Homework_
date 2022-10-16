// Задача 2: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. 
// Функция должна на вход принимать число, а выдавать сумму его цифр.
System.Console.WriteLine("Hello, friend! This program accept in input a number and count the sum value of input number.");
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int n = Prompt("Please, add a number ----> ");
System.Console.WriteLine("Great!");

int GetSum(int number)
{
    int sum = 0;
    while (number >0 )
    {
        int j= number % 10;
        number /= 10;
        sum +=j;
    }
    return sum;
}
bool ValidateNumber(int number)
{
    if (number<1)
    {
        System.Console.WriteLine("You enter the non positive number. This programm don't able to count the multiplication.");
        System.Console.WriteLine("Try again =)");
        return false;
    }
return true;
}

if (ValidateNumber(n))
{
int result = GetSum(n);
System.Console.WriteLine("Calculating......");
System.Console.Write("Result: ");
System.Console.WriteLine(result);
}