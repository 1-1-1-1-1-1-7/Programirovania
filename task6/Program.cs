//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
/*
int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int first = number / 10;р
int second = number % 10;
int max = first;

if (second > first)
{
    max = second;
}
System.Console.WriteLine(max);


if(first > second)
    System.Console.WriteLine(first);
else
    System.Console.WriteLine(second);
*/
    
int num = new Random().Next (100, 1000);
Console.WriteLine(num );

int num1 = num / 100;
int num2 = num % 10;
Console.WriteLine(num1 *10 + num2);

//.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число некратно первому, то программа выводит остаток от деления.
//34, 5 -> некратно, остаток 4
//16, 4 -> кратно

System.Console.WriteLine("Input 1st number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input 2nd number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok = number2 % number1;

if (ostatok == 0)
{
    System.Console.WriteLine("Correct");
}
else 
{
    System.Console.WriteLine(("Incorrect: " + ostatok));
}
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

System.Console.WriteLine("Вводим число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 ==0 && number % 23 == 0)
{
    System.Console.WriteLine("Correct");
}
else
{
    System.Console.WriteLine("Incorrect");
}
//.Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет
Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());


if (Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1 )
{ 
 Console.WriteLine("Да");   
}
 else {Console.WriteLine("Нет");}

 //