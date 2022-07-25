int number = 0;

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine();

bool enter = int.TryParse(userenter, out number);
if (enter)
{
    int count = 0;
    int ost = number % 10;
    while (ost != 0)
    {
        ost = number % 10;
        number = number / 10;
        count++;
        //Console.WriteLine(count);
    }

    int index = 0;
    int[] array = new int[count];

    while (index < array.Length)
    {
        ost = number % 10;
        number = number / 10;
        array[index] = ost;
        index++;
        Console.Write(array[index]);
    }

//Console.WriteLine("Second number is: ");
//Console.WriteLine(array[3]);
    
}
if (!enter)
{
    Console.Write("Wrong input");
}
