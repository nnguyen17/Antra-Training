//// See https://aka.ms/new-console-template for more information

//// num = "a string"; no no bad.
//// Examples to create data types
//int num = 0;
//string str = "Hello World";
//double dub = 3.1415d;
//float flo = 4.1415f;
//decimal deci = 5.1415m;
//bool flag = true;

////Outputting data types
//Console.WriteLine(num);
//Console.WriteLine(str);
//Console.WriteLine(dub);
//Console.WriteLine(flo);
//Console.WriteLine(deci);
//Console.WriteLine(flag);

////Example of string concatenation
//string hello = "Hello World" + " next words " + num;
//Console.WriteLine(hello);
////Example of string interpolation
//string strInter = $"Hello World \"flo\" =  {flo}";
//Console.WriteLine(strInter);

////states number
//int[] array1 = new int[5];
//array1[0] = 1;
//// State number and content
//int[] array2 = new int[5] { 0, 1, 2, 3, 4 };
//// States content omits number
//int[] array3 = new int[] { 0, 1, 2, 3, 4 };
//// Omits new 
//int[] array4 = { 0, 1, 2, 3, 4 };
////Two dimensional Array
//int[,] multiArray1 = new int[2, 3];
//int[,] multiArray2 = { {1, 2, 3 }, {4, 5, 6 } };

////Declare a jagged array
//int[][] jaggedArray = new int[6][];
//jaggedArray[0] = new int[3] { 1, 2, 3 };
//jaggedArray[1] = new int[5] { 1, 2, 3 , 4, 5};

//// for loop
//for( int i = 0; i < array1.Length; i++)
//{
//    Console.Write(array1[i] + " ");
//}

//// foreach 
//foreach(int i in array2)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();

//int[] arraySort = new int[5] { 4, 3, 2, 5, 20 };
//Array.Sort(arraySort);

//int valNull = null;
//string refNull = null;

//int box = 10;
//object obj = box; //boxing 
//int unbox = (int)obj; //Unboxing

using ConsoleApp1;
using System.Text;

//string strChar = "hello World";
//Console.WriteLine(strChar[0]);

////strChar[0] = 'H';

//StringBuilder strBui = new StringBuilder("hello World");
//Console.WriteLine($"Before change {strBui}");
//strBui[0] = 'H';
//Console.WriteLine($"After change {strBui}");

////passwords and username as string
//strChar = "Hello World";
//strChar = strChar + " Additional Strings";

////Enums
//int Monday = 1;
//int Tuesday = 2;
//int Wednesday = 3;
//int Thursday = 4;
//int Friday = 5;
//int Saturday = 6;
//int Sunday = 7;

//int whatIsToday = 25;
//if (whatIsToday == 3)
//{
//    Console.WriteLine("Its Wednesday");
//}


//DayOfWeek today = DayOfWeek.Monday;
//Console.WriteLine(today);

// Functions
// [Access Modifier] [static] return-type MethodName ([Formal-parameters]){
//      Statements
//}
PassParameters passParameters = new PassParameters();
//int a = 50;
//int b = 60;

//passParameters.PassByValue(a, b);
//Console.WriteLine($"Value: a = {a}, b = {b} sum = {a + b}");

//passParameters.PassByReference(ref a, ref b);
//Console.WriteLine($"Reference: a = {a}, b = {b} sum = {a + b}");

//passParameters.AreaOfCircle(10);
//passParameters.AreaOfCircle(10, 3);

//string str;
//Console.WriteLine(passParameters.isAuth("Bob", "Smith", out str));
//Console.WriteLine(str);

Console.WriteLine(passParameters.AddNumbers(10, 20));
Console.WriteLine(passParameters.AddNumbers(10, 20, 30, 40));

Console.WriteLine(passParameters.AddTwoNumbers(10, 20));