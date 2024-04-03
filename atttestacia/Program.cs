/* Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы. */
/* Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Summa(m, n);
void Summa(int m, int n)
{
    Console.Write(Sum(m - 1, n));
}
int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}
 */

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. */
/* Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
} */
/* Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы
 */
char[] array = {'!','я','а','ш','ч','у','Л'};
void Print (char[] array, int i)
{
    if(i < 0) return;
    Console.Write(array[i]);
    Print(array, i - 1);
}

Print(array, array.Length - 1);