/* int Fill_Array (int [] array_fill, int min) 
{
    int length = array_fill.Length;
    for(int i=0; i < length; i++)
    {
        array_fill[i] = min + 1;
    }
    return array_fill;
}

void Print_Array(int [] array_print)
{
    int length_print = array_print.Length;
    for(int i = 0; i < length_print; i++)
    {
        Console.Write($"{array_print[i]}");
    }
}
int[] arrayA = new int [30];
int min1 = 2;
arrayA = Fill_Array(arrayA, min1);
Print_Array(arrayA);
System.Console.WriteLine();
 */
Console.Clear();
int[] number = {2,90};
int n = 0;
int a = number[n];
int b = a*a;
while ( b < number.Length)
{
    for (int i = 0; i <= number.Length; i++)
    {
        if (number[i] == 2 || number[i] == 3 || number[i] == 5 || number[i] == 7)
        {
        System.Console.WriteLine($"Это простое число{number[i]}");
        }
    }
    n++;
}
	