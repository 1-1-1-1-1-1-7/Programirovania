/* Задайте одномерный массив, заполненный случайными целыми
числами. Определите количество четных чисел в этом
массиве. */

/* void FillArray (int start, int end, int[] arr)
{
    for (int i = 0 ; i < arr.Length; i++)    
    {
        arr[i] = new Random().Next (start, end);
    }
}
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int CountEven(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 ==0)
        {result++;}
    }
    return result;
}

int[] userarr = new int[10];
FillArray (1, 100, userarr);
PrintArray (userarr);
System.Console.WriteLine();
System.Console.WriteLine(CountEven (userarr)); */

/* Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые делятся нацело на 7 */

/* void FillArray (int[] arr)
{
System.Console.WriteLine("Заполните массив");
for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
 }    
}

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] user_arr = new int [size];
FillArray(user_arr);

int CountEven (int[] arr)
{
    int rezult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0)
        {rezult++;}
    }
    return rezult;
}
printArray(user_arr);
System.Console.WriteLine(CountEven(user_arr)); */
/* Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
 */
 int[] user_arr= FillArray(8);
PrintArray(user_arr);

int GetNumber (int[] arr)
{
    int rezult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        rezult = rezult * 10 + arr [i];
    }
    return rezult;
}
System.Console.WriteLine(GetNumber(user_arr));

Задача 1: Напишите программу, которая бесконечно
запрашивает целые числа с консоли. Программа
завершается при вводе символа ‘q’ или при вводе
числа, сумма цифр которого четная.

Задача 2: Задайте массив заполненный случайными
трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в
массиве.

Задача 3: Напишите программу, которая перевернёт
одномерный массив (первый элемент станет
последним, второй – предпоследним и т.д.)

