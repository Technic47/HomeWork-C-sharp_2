int number = 12345;
int[] array = {0,0,0,0,0};

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
   


