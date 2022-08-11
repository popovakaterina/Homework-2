//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Print your number: ");
int number = Convert.ToInt32(Console.ReadLine());
string strnumber = Convert.ToString(number);
if (strnumber.Length >2)
{
    Console.Write("Third element is: ");
    Console.Write(strnumber[2]);
}
else
{
    Console.Write("This number is shorter than tree elements!");
}