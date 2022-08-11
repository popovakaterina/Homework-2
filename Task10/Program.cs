// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

Console.WriteLine("Print your number: ");
int number = Convert.ToInt32(Console.ReadLine());
string strnumber = Convert.ToString(number);
Console.Write("Second figure is: ");
Console.Write(strnumber[1]);