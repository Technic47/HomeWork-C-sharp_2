﻿int number = 0;

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine();

bool enter = int.TryParse(userenter, out number);
if (enter)
{
    int count = 0;
    int number1 = number;
    int ost = 1;
    while (ost != 0) //count is for array.Length
    {
        number1 = number1 / 10;
        ost = number1 % 10;
        count++;
    }

    int index = 0;
    //Console.WriteLine($"Count is: {count}");
    int[] array = new int[count];

    while (index < array.Length)
    {
        ost = number % 10;
        number = number / 10;
        array[index] = ost;
        index++;
    }

Console.WriteLine("Second number is: ");
Console.WriteLine(array[array.Length - 2]);
    
}
if (!enter)
{
    Console.Write("Wrong input");
}
