System.Console.WriteLine("This prorgam outputs table of cubes from 1 to input number(N)");
int Prompt(string message)
{
Console.Write(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
int N = Prompt("Please, enter a number ---> ");
for (int i = 1; i <= N; i++)
{
Console.WriteLine(Math.Pow(i,3));
}