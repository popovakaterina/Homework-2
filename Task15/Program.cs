//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
while (true)
{
    Console.WriteLine("Print your number of a day or 0 to end: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Yes! This day is a weekend!!!");
    }
    else if (number > 8)
    {
        Console.WriteLine("Oops... It isn't a weekday.");
    }
    else if (number == 0)
    {
        break; 
    }
    else
    {
        Console.WriteLine("No! This day is a workday :(((");
    }
}