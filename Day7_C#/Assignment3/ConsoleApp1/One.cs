/* 03 Object-Oriented Programming
 * 
 * Test your knowledge
 * 1. What are the six combinations of access modifierkeywords and what do they do?
 * public: accessible everywhere
 * private: accessible in the same class or derived class
 * internal: accessible in the same assembly
 * protected: accessible only in the current class
 * private protected: accessed assembly in which it's declared, or from within a derived class in another assembly.
 * protected internal: accessible in the assembly in which it's declared, or from within a derived class in another assembly.
 * 
 * 2. What is the difference between the static, const, and readonly keywords when applied to a type member?
 * const must be assigned a value at declaration, and this value may not then change at a later time.
 * A static member (variable, method, etc) belongs to the type of an object rather than to an instance of that type. 
 * readonly field is one where assignment to that field can only occur as part of the declaration of the class or in a constructor.
 * 
 * 3. What does a constructor do?
 * is a special method which shares the same name of the class and doesn't have any return type, not even void; 
 * is used to create an object of the class and initialize class members
 * 
 * 4. Why is the partial keyword useful?
 * It allows multiple programmers to work on it at the same time.
 * 
 * 5. What is a tuple?
 * A tuple is a data structure that contains a sequence of elements of different data types
 * 
 * 6. What does the C# record keyword do?
 * It is used to define a reference type that provides built-in functionality for encapsulating data
 * 
 * 7. What does overloading and overriding mean?
 * Overloading: Methods in same class share the same method name, but different input parameters
 * Overriding: Methods in base class and its subclasses share the same method name and same input parameters
 * 
 * 8. What is the difference between a field and a property?
 * A field is a variable of any type that is declared directly in a class. 
 * A property is a member that provides a flexible mechanism to read, write or compute the value of a private field. 
 * 
 * 9. How do you make a method parameter optional?
 * Using a default value
 * 
 * 10. What is an interface and how is it different from abstract class?
 * Interface is a contract (gives a list of methods) which is implemented by the derived class
 * Differences: Interfaces supports multiple inheritance
                by default all members in the interface are public
                Interfaces can only have method declaration not implementation
                Interfaces can not have constructors. Abstract can.
                Interfaces cannot have variables
                Interfaces can still have properties
                typically properties are in entities to make loosely coupled code
                You cannot make an instance of an interface (like Abstract)
 * 11. What accessibility level are members of an interface?
 * public
 * 
 * 12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
 * True
 * 
 * 13. True/False. The override keyword is used to indicate that a method in a derived class 
 * is providing its own implementation of a method.
 * False
 * 
 * 14. True/False. The new keyword is used to indicate that a method in a derived class is
 * providing its own implementation of a method.
 * True
 * 
 * 15. True/False. Abstract methods can be used in a normal (non-abstract) class.
 * False
 * 
 * 16. True/False. Normal (non-abstract) methods can be used in an abstract class.
 * True
 * 
 * 17. True/False.Derived classes can override methods that were virtual in the base class.
 * True
 * 
 * 18. True/False.Derived classes can override methods that were abstract in the base class.
 * True
 * 
 * 19. True/False.In a derived class, you can override a method that was neither virtual non abstract in the base class.
 * False
 * 
 * 20. True/False. A class that implements an interfacedoes not have to provide an implementation for all of the members of the interface.
 * False
 * 
 * 21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
 * True
 * 
 * 22. True/False. A class can have more than one base class.
 * False
 * 
 * 23. True/False. A class can implement more than oneinterface.
 * True
 */

//Working with methods
/* 1. Let’s make a program that uses methods to accomplisha task. Let’s take an array and
 * reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
 * become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.To accomplish this, you’ll create three methods: 
 * one to create the array, one to reverse thearray, and one to print the array at the end.
 * YourMainmethod will look something like this:
 * 
 * static void Main(string[] args) {
 *    int[] numbers=GenerateNumbers();
 *    Reverse(numbers);
 *    PrintNumbers(numbers);
 * }
 * 
 * The GenerateNumbers method should return an array of 10 numbers. (For bonus points,change 
 * the method to allow the desired length to be passed in, instead of just always being 10.)
 * The PrintNumbers method should use a for or foreach loop to print out each item in the array.
 * The Reverse method will be the hardest. Give it a try and see what you can make happen.
 */
namespace ConsoleApp1
{
    public class One
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(2);
            Reverse(numbers);
            PrintNumbers(numbers);

            int[] GenerateNumbers(int length = 0)
            {
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Please enter element number {i + 1}");
                    int a = int.Parse(Console.ReadLine());
                    arr[i] = a;
                }
                return arr;
            }

            int[] Reverse(int[] arr)
            {
                int temp;
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    int tmp = arr[i];
                    arr[i] = arr[arr.Length - i - 1];
                    arr[arr.Length - i - 1] = tmp;
                }
                return arr;
            }

            void PrintNumbers(int[] arr)
            {
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }

            /* 2. The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and  1,
             * and every other number in the sequence after it is the sum of the two numbers before it.  
             * So the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
             * which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
             * number: 2 + 3 = 5. This keeps going forever.
             * The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
             * Because one number is defined by the numbers before it, this sets up a perfect opportunity for using recursion
             * Your mission, should you choose to accept it, is to create a method called Fibonacci, 
             * which takes in a number and returns that number of the Fibonacci sequence. So if someone 
             * calls Fibonacci(3), it would return the 3rd number in theFibonacci sequence, which is 2. 
             * If someone callsFibonacci(8), it would return 21.
             * In your Main method, write code to loop through the first 10 numbers of the Fibonacci sequence and print them out.
             */
            int Fibonacci(int n)
            {
                if (n == 1 || n == 2)
                {
                    return 1;
                }

                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            Console.WriteLine("The Fobonacci number is " + Fibonacci(10));
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"The {i} Fobonacci number is {Fibonacci(i)}");
            }
        }
    }
}