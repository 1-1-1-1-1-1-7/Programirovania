/* int[] test = { 5, 10, 2, 15, 25};
int num = 15;
for (int i = 0; i < test.Length; i++)
{
    if (test[i] == num)
    {
        System.Console.WriteLine("Yes");
    }
    else if (i == test.Length - 1)
    {
        System.Console.WriteLine("No");
    }
} */
int[,] Fill2Array(int row, int colum) //рандом 2-массива
{
    Random rnd = new Random();
    int[,] arr = new int[row, colum];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 100);
        }
    }
    return arr;
}
void Print2Array(int[,] arrayToPrint) //печать массива
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] arr = Fill2Array(3,5);
Print2Array(arr);
System.Console.WriteLine();
/* Print2DArray_New(arr);
 */
/* 1. Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты. */

/* int[,] ChetInArray(int[,] arr);
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
            }
        }
    }
    return arr;
} */
/* void Print2Array_New(int[,] arrayToPrint) //возведение в степень
{
Console.Write($"[ ]\t");
const int startIndex = 0;
for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
{
Console.Write($"[{(i)}]\t");
}
Console.WriteLine();
for (var i = 0; i < arrayToPrint.GetLength(0); i++)
{
Console.Write($"[" + i + "]\t");

for (int j = 0; j < arrayToPrint.GetLength(1); j++)
{
if (i % 2 == 0 && j % 2 == 0)
{
Console.Write(Convert.ToInt32(Math.Pow(arrayToPrint[i, j],2)) + "\t");
}
else
{
Console.Write(arrayToPrint[i, j] + "\t");
}
}
Console.WriteLine();
}
} */
/* Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д. */

int SumDiagonal (int[,] arr) // сумма диагонали
{
int sum = 0 ;
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if (i == j)
{sum = sum + arr[i,j];}
}
}
return sum;
}

int sum = SumDiagonal(arr);
System.Console.WriteLine(sum);

/* Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива. */
void PrintArray(int[,] arrayToPrint) //1д массив
{
double[] array = new double [arrayToPrint.GetLength(0)];
Console.Write("[");
for (int i = 0; i < arrayToPrint.GetLength(0); i++)
{
double sum = 0;
for (int j = 0; j < arrayToPrint.GetLength(1); j++)
{
sum = sum + arrayToPrint[i,j];
}
sum = sum / arrayToPrint.GetLength(1);
array[i] = sum;
Console.Write(array[i]);
if (i != array.Length - 1)
{
Console.Write(", ");
}
}
Console.Write("]");
Console.WriteLine();
}

int[,] arr = Fill2Array(3,5);
print2DArray(arr);
System.Console.WriteLine();
PrintArray(arr);