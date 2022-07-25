int number = 0;
int[] array = {0,0,0,0,0,0};

Console.WriteLine("Enter number: ");
string userenter = Console.ReadLine();

bool enter = int.TryParse(userenter, out number);
if (enter)
{
    int size = number % 10;
    int index = 0;
    while (size > 1)
    {
        size = number % 10;
        number = number / 10;
        array[index] = size;
        //Console.Write($"{array[index]} ");
        index++;
        //Console.Write($"{size} ");
        //Console.Write($"{number} ");
    
    }
Console.WriteLine("Second number is: ");
Console.WriteLine(array[1]);
    
}
if (!enter)
{
    Console.Write("Wrong input");
}
