//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = 0;

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine();

bool enter = int.TryParse(userenter, out number);
if (enter)
{
    int count = 0;
    int number1 = number;
    int ost = 1;
    while (ost != 0) //count is Length of future array
    {
        number1 = number1 / 10;
        ost = number1 % 10;
        count++;
    }

    if (count < 3)
    {
        Console.WriteLine("There is no 3rd digit in your number!");
    }
    else
    {
        int[] array = new int[count];

        for (int i = 0; i < array.Length; i++) //putting ost to array[index]
        {
            ost = number % 10;
            number = number / 10;
            array[i] = ost;
        }
        Console.WriteLine("Third number is: ");
        Console.WriteLine(array[array.Length - 3]); //array[-3] doesn`t work((

    }
        
}
if (!enter)
{
    Console.Write("Wrong input");
}
