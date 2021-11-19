int Fill_Array (int [] array_fill, int min) 
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

