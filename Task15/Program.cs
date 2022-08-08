/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день
*/

int[] array = { 0, 0, 0, 0, 0, 1, 1 };
int number = 0;

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine()!;

int.TryParse(userenter, out number);
if (number > 0 && number < 8)
{
    if (array[number - 1] == 1) Console.Write("This is a weekend.");
    else Console.Write("This is a working day.");
}
else Console.Write("There is no weekday for your number");

