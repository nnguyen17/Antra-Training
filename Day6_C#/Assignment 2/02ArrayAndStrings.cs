/* 02 Arrays and Strings
 * 
 * Test your knowledge
 * 
 * 1. When to use String vs. StringBuilder in C# ?
 * While working with the String class, every time you perform some operations on your string, 
 * you recreate the entire string in the memory over and over again, whereas StringBuilder allocates
 * some buffer space in the memory and applies modifications into that buffer space.
 * As the StringBuilder object is mutable, it provides better performance as compared to 
 * the String object when heavy string manipulations are involved.
 * 
 * 2. What is the base class for all arrays in C#?
 * Array class
 * 
 * 3. How do you sort an array in C#?
 * We can use Array.Sort() method
 * 
 * 4. What property of an array object can be used to get the total number of elements in an array?
 * Length property
 * 
 * 5. Can you store multiple data types in System.Array?
 * No
 * 
 * 6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
 * The Clone() method returns a new array containing all the elements in the original array. 
 * The CopyTo() method copies the elements into another existing array.
 * 
 */

//Practice Arrays

/* 1. Copying an Array
 * Write code to create a copy of an array. First, start by creating an initial array. 
 * (You can use whatever type of data you want.) Let’s start with 10 items. 
 * Declare an array variable and assign it a new array with 10 items in it. 
 * Use the things we’ve discussed to put some values in the array. 
 * Now create a second array variable. Give it a new array with the same length as the first. 
 * Instead of using a number for this length, use the Lengthproperty to get the size of 
 * the original array. 
 * Use a loop to read values from the original array and place them in the new array. 
 * Also print out the contents of both arrays, to be sure everything copied correctly.
 */
int[] arr = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

int[] arr2 = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    arr2[i] = arr[i];
}
Console.Write("arr: ");
foreach (int i in arr)
{
    Console.Write($"{i}, ");
}
Console.Write("\narr2: ");
foreach (int i in arr2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine("");

/* 2. Write a simple program that lets the user manage a list of elements. It can be 
 * a grocery list, "to do" list, etc. Refer to Looping Based on a Logical Expression 
 * if necessary to see how to implement an infinite loop. Each time through the loop, 
 * ask the user to perform an operation, and then show the current contents of their list. 
 * The operations available should be Add, Remove, and Clear. The syntax should be as follows:
 * 
 * + some item
 * - some item
 * --
 * 
 * Your program should read in the user's input and determine if it begins with a
 * “+” or “-“ or if it is simply  “—“ . In the first two cases, your program should add or remove 
 * the string given ("some item" in the example). If the user enters just “—“ then the program 
 * should clear the current list. Your program can start each iteration through its loop 
 * with the following instruction:
 * 
 * Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
 * 
 */
string a = "";
List<string> list = new List<string>();
while (a != "")
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string b = Console.ReadLine();
    string[] c = b.Split(" ");
    if (c[0] == "+")
        list.Add(c[1]);
    if (c[0] == "-")    
        list.Remove(c[1]);
    if (c[0] == "--")
        list.Clear();
    for (int i = 0; i < list.Count; i++)
        Console.WriteLine(list[i]);
}

// 3. Write a method that calculates all prime numbers in given range and returns them as array of integers
static int[] FindPrimesInRange(int startNum, int endNum)
{
    int[] primes = new int[endNum-startNum+1];
    int test;
    for (int i = startNum; i <= endNum; i++)
    {
        if (i == 1 || i == 0)
            continue;
        test = 1;
        for (int j = 2; j <= i / 2; ++j)
        {
            if (i % j == 0)
            {
                test = 0;
                break;
            }
        }
        if (test == 1)
            primes[i] = i;
    }
    return primes;
}
FindPrimesInRange(1, 4);

/* 4. Write a program to read an array of n integers (space separated on a single line) and 
 * an integer k, rotate the array right ktimes and sum the obtained arrays after each rotation 
 * as shown below.
 * After r rotations the element at position I goes to position (I + r) % n.
 * The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1
 */
Console.WriteLine("Please enter an array");
string ar = Console.ReadLine();
string[] sar = ar.Split(" ");
int[] isar = Array.ConvertAll(sar, int.Parse);
Console.WriteLine("Please enter number of time to rotate");
int k = int.Parse(Console.ReadLine());

// 5. Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.
int count = 1, tempCount = 1, number = 0;

Console.Write("Enter array length: ");
int length = Int32.Parse(Console.ReadLine());
int[] arr1 = new int[length];

for (int i = 0; i < arr1.Length; i++)
{
    Console.Write("Enter {0} element: ", i);
    arr1[i] = Int32.Parse(Console.ReadLine());
}

for (int i = 0; i < arr1.Length - 1; i++)
{
    if (arr1[i] == arr1[i + 1]) tempCount++;
    else tempCount = 1;

    if (tempCount > count)
    {
        count = tempCount;
        number = arr1[i];
    }
}

for (int i = 0; i < count; i++) Console.Write("{0}, ", number);

/* 7. Write a program that finds the most frequent number in a given sequence of numbers.  
 * In case of multiple numbers with the same maximal frequency, print the leftmost of them
 */


//Practice Strings
/* 1. Write a program that reads a string from the console, reverses its letters and prints the result back at the console
 * Write in two ways
 * Convert the string to char array, reverse it, then convert it to string again
 * Print the letters of the string in back direction (from the last to the first) in a for-loop
 */
Console.WriteLine("\nPlease enter a string");
string s = Console.ReadLine();
char[] ch = s.ToCharArray();
Array.Reverse(ch);
foreach (char c in ch)
{
    Console.Write(c);
}

Console.WriteLine("\nPlease enter a string");
string str = Console.ReadLine();
for (int i = str.Length - 1; i >= 0; i--)
{
    Console.Write(str[i]);
}

/* 2. Write a program that reverses the words in a given sentence without changing the punctuation and spaces
 * Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
 * All other characters are considered part of words, e.g. C++, a+b, and a77 are considered valid words.
 * The sentences always start by word and end by separator.
 */
Console.WriteLine("\nPlease enter a string");
string ds = Console.ReadLine();


/* 3. Write a program that extracts from a given text all  palindromes, 
 * e.g. “ABBA”, “lamal”, “exe” and prints them on the console on a single line, 
 * separated by comma and space.Print all unique palindromes (no duplicates), sorted
 */

/* 4. Write a program that parses an URL given in the following format:[protocol]://[server]/[resource]
 * The parsing extracts its parts: protocol, server and resource.
 * The [server] part is mandatory.
 * The [protocol] and [resource] parts are optional.
 */
Console.WriteLine("Please enter an URL");
string url = Console.ReadLine();
Uri uri = new Uri(url);
Console.WriteLine("[protocol] = " + uri.Scheme);
Console.WriteLine("[server] = " + uri.Host);
Console.WriteLine("[resource] = " + uri.AbsolutePath);

