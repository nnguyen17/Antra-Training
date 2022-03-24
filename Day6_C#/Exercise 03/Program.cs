//Practice loops and operators

/* 1. FizzBuzzis a group word game for children to teach them about division. 
 * Players take turns to count incrementally, replacing any number divisible by three 
 * with the word /fizz/, any number divisible by five with the word /buzz/, 
 * and any number divisible by both with /fizzbuzz/. Create a console application 
 * in Chapter03 named Exercise03 that outputs a simulated FizzBuzz game counting up to 100. 
 */

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine("/fizzbuzz/"); 
    else if (i % 5 == 0)
        Console.WriteLine("/buzz/");
    else if (i % 3 == 0)
        Console.WriteLine("/fizz/");
    else
        Console.WriteLine(i);
}

/* What will happen if this code executes? 
 * 
 * int max =500;
 * for(byte i =0; i < max; i++){
 *      WriteLine(i);
 * }
 * 
 * Create a console application  and enter the preceding code. 
 * Run the console application and view the output. What happens?
 * It results in an infinite loop
 * 
 * What code could you add (don’t change any of the preceding code) to warn us about the problem?
 * Use Console.WriteLine to state the problem
 */


/* 2. Print-a-Pyramid.Like the star pattern examples that we saw earlier, 
 * create a program that will print the following pattern: 
 * If you find yourself getting stuck, try recreating the two examples that 
 * we just talked about in this chapter first. They’re simpler, and you can compare 
 * your results with the code included above. 
 */
for(int i = 0; i < 5; i++)
{
    for(int j = 1; j < 5 - i; j++)
        Console.Write(" ");
    for (int j = 1; j <= 2 * i - 1; j++)
        Console.Write("*");
    Console.WriteLine("\n");
}

/* 3. Write a program that generates a random number between 1 and 3 and asks the user 
 * to guess what the number is. Tell the user if they guess low, high, or get the correct answer. 
 * Also, tell the user if their answer is outside of the range of numbers that are 
 * valid guesses (less than 1 or more than 3). You can convert the user's typed answer 
 * from astring to anint using this code:
 * 
 * int guessedNumber =int.Parse(Console.ReadLine());
 * 
 * Note that the above code will crash the program if the user doesn't type an integer value. 
 * For this exercise, assume the user will only enter valid guesses.
 */
int a = 0;
int correctNumber = new Random().Next(3) + 1;
while (a == 0)
{
    Console.WriteLine("Please enter your guess");
    int guessedNumber = int.Parse(Console.ReadLine());
    if (guessedNumber == correctNumber)
    {
        Console.WriteLine("Correct");
        a = 1;
    }
    else if (guessedNumber < correctNumber)
        Console.WriteLine("Lower than correct answer");
    else if (guessedNumber > correctNumber)
        Console.WriteLine("Higher than correct answer");
    if (guessedNumber < 1 || guessedNumber > 3)
        Console.WriteLine("Your answer is outside of the range of numbers that are valid guesses");
}

/* 4. Write a simple program that defines a variable representing a birth date and 
 * calculates how many days old the person with that birth date is currently.
 * For extra credit, output the date of their next 10,000 day (about 27 years) anniversary. 
 * Note: once you figure out their age in days, you can calculate the days until 
 * the next anniversary usingint daysToNextAnniversary = 10000 - (days % 10000);
 */
Console.WriteLine("Please enter your birth date (mm/dd/yy)");
String bd = Console.ReadLine();
String[] split = bd.Split("/");
int[] arr = new int[3];
for (int i = 0; i < 3; i++)
    arr[i] = int.Parse(split[i]);
int year, month, day;
if (arr[0] < 3 && arr[1] < 24)
{
    year = 2022 - arr[2];
}


/* 5. Write a program that greets the user using the appropriate greeting for the time of day. 
 * Use onlyif, notelse orswitch, statements to do so. Be sure to include the following greetings:
 * "Good Morning"
 * "Good Afternoon"
 * "Good Evening"
 * "Good Night"
 */
DateTime dt = DateTime.Now;
int time = dt.Hour;
if (time >= 6 && time <= 12)
{
    Console.WriteLine("Good Morning");
}
if (time > 12 && time <= 18)
{
    Console.WriteLine("Good Afternoon");
}
if (time > 18 && time <= 23)
{
    Console.WriteLine("Good Evening");
}
if (time > 23 || time < 6)
{
    Console.WriteLine("Good Night");
}

/* Write a program that prints the result of counting up to 24 using four different increments. 
 * First, count by 1s, then by 2s, by 3s, and finally by 4s.Use nestedfor loops 
 * with your outer loop counting from 1 to 4. You inner loop should count from 0 to 24, 
 * but increase the value of its /loop control variable/ by the value of 
 * the /loop control variable/ from the outer loop. This means the incrementing 
 * in the /afterthought/ expression will be based on a variable.
 */
for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j <= 24; j += i)
        Console.Write($"{j}, ");
    Console.WriteLine("\n");
}