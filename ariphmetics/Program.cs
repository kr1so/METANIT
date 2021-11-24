//S1.1. Вывести на экран число  с точностью до сотых.
//----------------------------------------------------
/* Console.Clear();
double a = 2.23;
System.Console.WriteLine("Вывод числа с учетом сотых");
System.Console.WriteLine(a); */
//----------------------------------------------------

//S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
//----------------------------------------------------
/* Console.Clear();
double e = 2.7;
System.Console.WriteLine("Вывести на экран число 'e' (основание натурального логарифма) с точностью до 10-ых");
System.Console.WriteLine(e); */
//----------------------------------------------------

//S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. 
//Выводимому числу должно предшествовать сообщение «Вы ввели число».
//----------------------------------------------------
/* Console.Clear();
System.Console.WriteLine("Введите число");
string? num = Console.ReadLine();
System.Console.WriteLine("Вы ввели число");
Console.Write(num);  */
//пример с использованием интерполяции строк
/* Console.Write("Введите число - ");
string? number = Console.ReadLine();
Console.WriteLine($"Вы ввели число : {number}"); */
//----------------------------------------------------

/* S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. 
После выводимого числа должно следовать сообщение » — вот какое число Вы ввели».*/
//----------------------------------------------------
/* System.Console.Write("Введите число - ");
string? number = Console.ReadLine();
System.Console.WriteLine($"Вот какое число Вы ввели: {number}"); */
//----------------------------------------------------

//S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
//----------------------------------------------------
/* Console.Clear();
int a = 1, b = 13, c = 49;
Console.WriteLine($"{a} {b} {c}"); */
//----------------------------------------------------

//S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
/* Console.Clear();
int a = 7, b = 15, c = 100;
System.Console.WriteLine($"{a}  {b}  {c}"); */
//----------------------------------------------------

//S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
/* Console.Clear();
int a = new Random().Next(-10,10);
int b = new Random().Next(-10,10);
int c = new Random().Next(-10,10);
System.Console.WriteLine($"{a}  {b}  {c}"); */
//----------------------------------------------------

//S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.
//----------------------------------------------------
/* Console.Clear();
int a = new Random().Next(-10,10);
int b = new Random().Next(-10,10);
int c = new Random().Next(-10,10);
int d = new Random().Next(-10,10);
System.Console.WriteLine($"{a} {b} {c} {d}"); */

//если вводит пользователь:
/* Console.Clear();
System.Console.Write("Введите число #1 - ");
string? a = Console.ReadLine();
System.Console.Write("Введите число #2 - ");
string? b = Console.ReadLine();
System.Console.Write("Введите число #3 - ");
string? c = Console.ReadLine();
System.Console.Write("Введите число #4 - ");
string? d = Console.ReadLine();
System.Console.WriteLine($"Введенные числа: {a} {b} {c} {d}"); */
//----------------------------------------------------

//S1.9. Вывести на экран числа 50 и 10 одно под другим.
//----------------------------------------------------
/* int a = 50;
int b = 10;
System.Console.WriteLine(a);
System.Console.WriteLine(b); */
//----------------------------------------------------

//S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.
//----------------------------------------------------
/* Console.Clear();
int a = 5, b = 10, c = 21;
System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c); */
//----------------------------------------------------

//S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.
/* Console.Clear();
System.Console.WriteLine("Введите число #1");
string? a = Console.ReadLine();
System.Console.WriteLine("Введите число #2");
string? b = Console.ReadLine();
System.Console.WriteLine("Введите число #3");
string? c = Console.ReadLine();
System.Console.WriteLine("Введите число #4");
string? d = Console.ReadLine();
System.Console.WriteLine("Введённые числа:");
System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(d); */
/* int Method(int number)
    {
    int count = 0;
    while(count<3)
        {
        string? a = Console.ReadLine();
        string? b = Console.ReadLine();
        string? c = Console.ReadLine();
        string? d = Console.ReadLine();
        count++;
        }
        return number;
    }

System.Console.WriteLine(Method(1));

int Method(int number)
    {
    int count = 0;
    while(count<3)
        {
        string? a = Console.ReadLine();
        string? b = Console.ReadLine();
        string? c = Console.ReadLine();
        string? d = Console.ReadLine();
        count++;
        }
        return number;
    } */
/* Console.Clear();
int Method(int result)
{
    int[] A = new int [3];
    for (int count = 0; count < 3; count++)
    {
        int number = count;
        System.Console.WriteLine("Введите число {number}");
        number++;
        int A[count] = Console.ReadLine();
    }
    return result;
}
System.Console.WriteLine(Method()); */

