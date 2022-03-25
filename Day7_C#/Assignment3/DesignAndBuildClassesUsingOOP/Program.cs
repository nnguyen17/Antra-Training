/* Designing and Building Classes using object-oriented principles
 * 
 * 1. Write a program that that demonstrates use of four basic principles of object-oriented programming
 * /Abstraction/, /Encapsulation/, /Inheritance/ and /Polymorphism/.
 * 
 * 2. Use /Abstraction/ to define different classes for each person type such as 
 * Student and Instructor. These classes should have behavior for that type of person.
 * 
 * 3. Use /Encapsulation/ to keep many details privatein each class.
 * 
 * 4. Use /Inheritance/ by leveraging the implementation already created in the Person class 
 * to save code in Student and Instructor classes.
 * 
 * 5. Use /Polymorphism/ to create virtual methods that derived classes could override to create 
 * specific behavior such as salary calculations.
 * 
 * 6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
 * IInstructorService, IDepartmentService, IPersonService, 
 * IPersonService should have person specific methods. 
 * IStudentService, IInstructorService should inherit from IPersonService.
 */

namespace DesignAndBuildClassesUsingOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dashboard db = new Dashboard();
            db.Run();

            /* 7. Try creating the two classes below, and make asimple program to work with them, as described below
             * Create a Color class:
             * On a computer, colors are typically represented with a red, green, blue, and 
             * alpha(transparency) value, usually in the range of 0 to 255. Add these as 
             * instance variables.A constructor that takes a red, green, blue, and alpha value.
             * A constructor that takes just red, green, and blue, while alpha defaults to 255(opaque).
             * Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
             * A method to get the grayscale value for the color, which is the average of the red, green and  blue values.
             * 
             * Create a Ball class:
             * The Ball class should have instance variables for size and color (the Color class 
             * you just created). Let’s also add an instance variable that keeps track of the number of times 
             * it has been thrown.
             * Create any constructors you feel would be useful.
             * Create a Pop method, which changes the ball’s size to 0.
             * Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been popped (has a size of 0).
             * A method that returns the number of times the ball has been thrown.
             * 
             * Write some code in your Main method to create a few balls, throw them around a few times,
             * pop a few, and try to throw them again, and print out the number of times that the
             * balls have been thrown. (Popped balls shouldn’t have changed.)
             */
            Ball b = new Ball(3);
            Ball b1 = new Ball(1, 2, 3);
            Ball b2 = new Ball(4, 5, 6);
            Ball b3 = new Ball(7, 8, 9);

            b1.Throw();
            b1.Throw();
            b1.Throw();
            b1.Throw();
            b2.Throw();
            b2.Throw();
            b3.Throw();
            b3.Throw();
            b3.Throw();
            b3.Throw();
            b3.Throw();
            b3.Throw();

            Console.WriteLine("The number of Balls: " + b.Size);
            Console.WriteLine("Number of throws for b1: " + b1.CThrow());
            Console.WriteLine("Number of throws for b2: " + b2.CThrow());
            Console.WriteLine("Number of throws for b3: " + b3.CThrow());

        }
        
    }
}

