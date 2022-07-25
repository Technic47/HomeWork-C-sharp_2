int number = 0;
int[] array = {0,0,0,0,0,0};

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine();

bool enter = int.TryParse(userenter, out number);
if (enter)
{
    int count = 0;
    int size = number % 10;
    int index = 0;
    while (size > 1)
    {
        size = number % 10;
        number = number / 10;
        array[index] = size;
        index++;
        count++;
        Console.WriteLine(count);
    }
//Console.WriteLine("Second number is: ");
//Console.WriteLine(array[3]);
    
}
if (!enter)
{
    Console.Write("Wrong input");
}
