/*01 Introduction to C# and Data Types
 * 
 *Understanding Data Types
 *
 *Test your knowledge
 *
 *1. What type would you choose for the following “numbers”? 
 *  A person’s telephone number: string
 *  A person’s height: double
 *  A person’s age: integer
 *  A person’s gender (Male, Female, Prefer Not To Answer): string
 *  A person’s salary: double
 *  A book’s ISBN: string
 *  A book’s price: decimal
 *  A book’s shipping weight: double
 *  A country’s population: integer
 *  The number of stars in the universe: integer
 *  The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): integer
 *  
 *  2. What are the difference between value type and reference type variables? What is boxing and unboxing?
 *  Value type variables directly contain their data while reference type variable store reference to their data (object)
 *  Each value type variable has its own copy of data while two reference varible can reference the same object
 *  Operation on one value type variable can not affect another while operation on reference variable can affect another
 *  Boxing is an implicit conversion of a value type to the type object or to any interface type implemented by this value type
 *  Unboxing is an explicit conversion from the type object to a value type or from an interface type to a value type that implements the interface
 *  
 *  3. What is meant by the terms managed resource and unmanaged resource in .NET
 *  Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. Unmanaged resources are those that are not.
 *  
 *  4. Whats the purpose of Garbage Collector in .NET? 
 *  .NET's garbage collector manages the allocation and release of memory for the application.
 *  
 *  */

//Playing with Console App

Console.WriteLine("Hacker Name Generator");
Console.WriteLine("Please enter your favorite color");
string a = Console.ReadLine();
Console.WriteLine("Please enter your astrology sign");
string b = Console.ReadLine();
Console.WriteLine("Please enter your street address number");
string c = Console.ReadLine();
Console.WriteLine($"Your hacker name is {a}{b}{c}");

