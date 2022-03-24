using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PassParameters
    {
        public void PassByValue(int a, int b)
        {
            a = 30;
            b = 10;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b}");
        }
        public void PassByReference(ref int a, ref int b)
        {
            a = 30;
            b = 10;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b}");
        }

        public void AreaOfCircle(double radius, double pi = 3.14)
        {
            Console.WriteLine($"Area of Circle = {pi * radius * radius}");
        }

        public bool isAuth(string uname, string password, out string msg)
        {
            msg = "";
            if (uname == "Bob" & password == "Smith")
            {
                msg = "verified";
                return true;
            }else if (uname != "Bob")
            {
                msg = "uname wrong bad";
            }else if(password != "Smith")
            {
                msg = "password wrong bad";
            }
            return false;
        }
        [Obsolete("Use AddNumbers(params int[] arr)", true)]
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
        public int AddThreeNumbers(int a, int b, int c)
        {
            return a + b + c;
        }

        public int AddNumbers(params int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
    }
}
