/* int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;
System.Console.WriteLine(arr[0]);
System.Console.WriteLine(arr[1]);
System.Console.WriteLine(arr[2]);
System.Console.WriteLine(arr[3]);
System.Console.WriteLine(arr[4]); */
/* System.Console.WriteLine(arr[5]); */

/* 
int[] arr2 = new int[] { 1, 2, 3, 4, 5 };

int[] arr3 = { 1, 2, 3, 4, 5 };
 */
/* int n = 10;
int[] arr = new int[n];
int i = 0;
while (i < n)
{
    arr[i] = i + 1;
    System.Console.WriteLine(arr i);
    System.Console.WriteLine(' '); 
    System.Console.Write($"{arr[i]}");
    i = i + 1;
}  */

/* int n = 10;
int[] array = {2, 5, 4, 7, 8, 35, 1, 3, 8, 5};
int i = 0;
while(i < n)
{
    if(array[i] % 2 == 0)
    {
        System.Console.WriteLine($"{array[i]} ");
    }
    i = i + 1;
} */
int n = 5;
int[] array = { 2, 13, 7, 3, 9 };
int i = 0;
int max = array[0];

while(i < n)
{
    if ( array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if ( array[j] > max)
    {
        max = array[j];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach(int e in array)
{
    if ( e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);