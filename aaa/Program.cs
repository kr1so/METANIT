 int Fill_Array (int[] array_fill, int min) 
{
    int length = array_fill.Length;
    int i = 0;
    while (i<length)
    {
        array_fill[i] = min + i;
        i++;
    } 
    return array_fill[i];
}
void Print_Array(int[] array_print)
{
    int length_print = array_print.Length;
    for(int j = 0; j < length_print; j++)
    {
        Console.Write($"{array_print[j]}");
    }
}
Console.Clear();
int[] number = new int [1000];
int min_Value = 6;
Fill_Array(number, min_Value);
int b = 0;
while ( (number[b] * number[b]) < number.Length)
{
    for (int c = 0; b <= number.Length; c++)
    {
        if (number[b] == 2 || number[b] == 3 || number[b] == 5 || number[b] == 7)
        {
        System.Console.WriteLine($"Это простое число: {number[b]}");
        b++;
        } 
    }
}
Print_Array(number);