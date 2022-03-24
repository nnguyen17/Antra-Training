/* Practice number sizes and ranges
 * 
 * 1. Create a console application project named /02UnderstandingTypes/ that outputs the number of bytes 
 * in memory that each of the following number types uses, and the minimum and maximum values 
 * they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
 * 
 * */

Console.WriteLine("Number of bytes in memory of SByte: " + sizeof(SByte));
Console.WriteLine("Minimum values SByte: " + SByte.MinValue);
Console.WriteLine("Maximum values SByte: " + SByte.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of Byte: " + sizeof(Byte));
Console.WriteLine("Minimum values Byte: " + Byte.MinValue);
Console.WriteLine("Maximum values Byte: " + Byte.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of short: " + sizeof(short));
Console.WriteLine("Minimum values short: " + short.MinValue);
Console.WriteLine("Maximum values short: " + short.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of ushort: " + sizeof(ushort));
Console.WriteLine("Minimum values ushort: " + ushort.MinValue);
Console.WriteLine("Maximum values ushort: " + ushort.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of int: " + sizeof(int));
Console.WriteLine("Minimum values int: " + int.MinValue);
Console.WriteLine("Maximum values int: " + int.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of uint: " + sizeof(uint));
Console.WriteLine("Minimum values uint: " + uint.MinValue);
Console.WriteLine("Maximum values uint: " + uint.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of long: " + sizeof(long));
Console.WriteLine("Minimum values long: " + long.MinValue);
Console.WriteLine("Maximum values long: " + long.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of ulong: " + sizeof(ulong));
Console.WriteLine("Minimum values ulong: " + ulong.MinValue);
Console.WriteLine("Maximum values ulong: " + ulong.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of float: " + sizeof(float));
Console.WriteLine("Minimum values float: " + float.MinValue);
Console.WriteLine("Maximum values float: " + float.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of double: " + sizeof(double));
Console.WriteLine("Minimum values double: " + double.MinValue);
Console.WriteLine("Maximum values double: " + double.MaxValue + "\n");

Console.WriteLine("Number of bytes in memory of decimal: " + sizeof(decimal));
Console.WriteLine("Minimum values decimal: " + decimal.MinValue);
Console.WriteLine("Maximum values decimal: " + decimal.MaxValue + "\n");

//2. Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds. 
Console.WriteLine("Please enter number of centuries");
int i = Convert.ToInt32(Console.ReadLine());
int year = i * 100;
long day = year * 365;
long hour = day * 24;
long minute = hour * 60;
long second = minute * 60;
long millisecond = second * 1000;
long microsecond = millisecond * 1000;
long nanosecond = microsecond * 1000;
if (i <= 0)
{
    Console.WriteLine("0 century = 0 year = 0 day = 0 hour = 0 minute = 0 second = 0 millisecond = 0 microsecond = 0 nanosecond");
} else
{
    Console.WriteLine($"{i} centuries = {year} years = {day} days = {hour} hours = {minute} minutes = {second} seconds = {millisecond} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds");
}

/* Controlling Flow and Converting Types 
 * 
 * Test your Knowledge
 * 1.What happens when you divide an int variable by 0? 
 * It will throw a compile time error which means that it is undefined
 * 
 * 2.What happens when you divide a double variable by 0? 
 * It will result in positive infinity, negative infinity or not a number (NaN)
 * 
 * 3.What happens when you overflow an int variable, that is, set it to a value beyond its range? 
 * The result becomes a negative number
 * 
 * 4.What is the difference between x = y++; and x = ++y;? 
 * For x = y++, the variable y will be incremented after assigning its value to x
 * For x = ++y, the variable y will be incremented before assigning its value to x
 * 
 * 5.What is the difference between break, continue, and return when used inside a loop statement? 
 * The break statement: terminates the closest enclosing iteration statement or switch statement.
 * The continue statement: starts a new iteration of the closest enclosing iteration statement.
 * The return statement: terminates execution of the function in which it appears and returns control to the caller.
 * 
 * 6.What are the three parts of a for statement and which of them are required? 
 * A for loop consists of the initializer, the condition and the iterator. All are optional
 * 
 * 7.What is the difference between the = and == operators? 
 * The = is an assignment operator while the == is a relational or comparison operator
 * 
 * 8.Does the following statement compile? for ( ; true; ) ; 
 * Yes
 * 
 * 9.What does the underscore _ represent in a switch expression? 
 * The underscore _ replaces the default keyword to signify that it should match anything if reached
 * 
 * 10.What interface must an object implement to be enumerated over by using the foreach statement?
 * The IEnumerable Interface
 * 
 * */


