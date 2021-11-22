/*  int[] Fill_Array (int[] array_fill, int min) 
{
    int length = array_fill.Length;
    int i = 0;
    while (i<length)
    {
        array_fill[i] = min + i;
        i++;
    } 
    return array_fill;
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
        while (number[b] == 2 || number[b] == 3 || number[b] == 5 || number[b] == 7)
        {
        System.Console.WriteLine($"Это простое число: {number[b]}");
        b++;
        } 
        //(number[b] == 2 || number[b] == 3 || number[b] == 5 || number[b] == 7)
    }
}
Print_Array(number); */

// Рабочий код задачи решета:
/* 
bool IsPrimeNumber(int number)
{
    if (number<2)
    {
        return false;
    }
    for (int i = 2; i < number; i++)
    {
        if (number%i==0)
        {
            return false;
        }
    }
    return true;
}
int? min_Value = int.Parse(System.Console.ReadLine());
for (int i = min_Value.Value; i < 30; i++)
{
    if (IsPrimeNumber(i))
    {
       System.Console.WriteLine(i);
    }
} */

/* for (int i = 1; i < 10; i++)
{
    int a = 2;
    if (i%2==0)
    {
            System.Console.WriteLine(i);
    }
} */

//Сергей показывал одну из задач с семинара 6.

/* int [] CreateArray(int count)
{
return new int[count];
}

string PrintArray(int[]array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
        
    }
    return result;
}
void FillArray(int[]array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(min,max+1); 
    }

}
int[] a1 = CreateArray(12);
FillArray(a1, 0, 10);
System.Console.WriteLine(PrintArray(a1)); */


/* //23. Показать таблицу квадратов чисел от 1 до N
 string squad (int N)
    {
        string result = string.Empty;
            for (int i = 0; i <= N; i++)
            {   // \n перенос строки
                result += $"{i*i} \n";
            }
            return result;
    }
System.Console.WriteLine(squad(12)); */

//24. Найти кубы чисел от 1 до N

// здесь показано решение только поиска кубов в кратком варианте
/* int N = 4;
int cube = N*N*N;
System.Console.WriteLine(cube); */

//здесь метод поиска куба ЧИСЛА, доработать до корректности
/*  int Cube (int N)
{   
    int cube = 0;
    for (int i = 1; i <= N; i++)
    {
        cube += (N*N*N)*i;
    }
     return cube;
}
System.Console.WriteLine(Cube(2)); */

//25. Найти сумму чисел от 1 до А
/* int n = 3;
int summary = (n *(n+1))/2;
System.Console.WriteLine(summary); */

/* int Sum (int A)
{   
    int summary = 0;
    for (int i = 1; i <= A; i++)
    {
        //summary = summary + i;
        summary += i;
    }
     return summary;
}
System.Console.WriteLine(Sum(3));
 */
//26. Возведите число А в натуральную степень B используя цикл
