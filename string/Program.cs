int a = 1;
int b = 3;
//System.Console.WriteLine($"переменная {b} > переменной {a}");
string st = "Hello World";
for (int i = 0; i < st.Length; i++)
{
 //   System.Console.Write(st[st.Length-1-i]);
}

string st1 = "";
string st2 = String.Empty;
string st3 = new string('z',5);
System.Console.WriteLine(st3);

char[] new_char = { 'w', 'o', 'r', 'l', 'd' };
string st4 = new string(new_char);
System.Console.WriteLine(st4);
char[] char_arr = new char [st4.Length];
for (int i = 0; i < st4.Length; i++)
{
    char_arr[i] = st4[i];
    System.Console.Write(char_arr[i]);
}
System.Console.WriteLine();

string s5 = "apple";
string s6 = "a day";
string s7 = "keeps";
string s8 = "a doctor";
string s9 = "away";

string[] stArray = new string [] {s5, s6, s7, s8, s9};
for (int i = 0; i < stArray.Length; i++)
{
    System.Console.Write($"{stArray[i]} ");
}
System.Console.WriteLine();

string fruits = "Яблоко, Банан, Груша";

string[] fruArr = fruits.Split(", ");
for (int i = 0; i < fruArr.Length; i++)
{
    System.Console.Write($"{fruArr[i]} ");
}
System.Console.WriteLine();
string text = "хотим увидеть прикольную приколюху";
string[] textArr = text.Split(" ");
PrintArray(textArr);

void PrintArray (string[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // меняет цвет выводимого текста
        Thread.Sleep(100); //пауза 
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write(" ]");
    Console.ResetColor();
}
System.Console.WriteLine();
string str = "Она несла в руках отвратительные, тревожные желтые цветы. "
            +"Черт их знает, как их зовут, но они первые почему-то появляются в Москве."
            +" И эти цветы очень отчетливо выделялись на черном ее весеннем пальто. Она"
            +" несла желтые цветы! Нехороший цвет. Она повернула с Тверской в переулок и"
            +" тут обернулась. Ну, Тверскую вы знаете?";

string[] separate = {", "," ",". ","! ","?","-"}; 
string[] stArr1 = str.Split(separate, StringSplitOptions.RemoveEmptyEntries); //принять группу разделителей

for (int i = 0; i < stArr1.Length; i++)
{
    System.Console.Write(stArr1[i]);
}
string strnum = "1,2,3,4,5";
int[] Num = new int[strnum.Length];
string[] charArr = strnum.Split(",");
for (int i = 0; i < strnum.Length; i++)
{
    Num[i] = Convert.ToInt32(charArr[i]);
    System.Console.WriteLine(Num[i]);
}

System.Console.WriteLine();