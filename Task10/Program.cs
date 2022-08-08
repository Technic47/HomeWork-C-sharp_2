/*Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
*/
int number = 0;

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine()!;

int.TryParse(userenter, out number);
int count = 0;
int number1 = number;
int ost = 1;
for (int i = 0; ost != 0; i++)
{
    number1 = number1 / 10;
    ost = number1 % 10;
    count++;
}

int[] array = new int[count];

for (int i = 0; i < array.Length; i++)
{
    ost = number % 10;
    number = number / 10;
    array[i] = ost;
}

Console.WriteLine($"Second number is: {array[array.Length - 2]}");


