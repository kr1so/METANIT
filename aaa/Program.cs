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
//пример того как должен заполняться массив числами
// мы вводим число n, которое по условию изначально равно min (2)
//далее если квадрат этого числа делится без остатка на на min (то есть или оно кратно min) 
//то мы выводим на консоль число n 
// и увеличивает min на 1 шаг для дальнейших расчетов
//заканчивается всё пока не закончатся числа в массиве
for (int n = min*min; min < length; min ++)
{
    if (n%min==0)
    {
        System.Console.WriteLine($"Все неподходящие нам числа: {n}");
    }
}
//а вот как найти наоборот, подходящие? поменять условие на n%min==1?
