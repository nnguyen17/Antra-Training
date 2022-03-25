using DesignAndBuildClassesUsingOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public class Choose
    {
        public Person GetObject(int choice)
        {
            switch (choice)
            {
                case (int)Options.Student:
                    return new Student();
                case (int)Options.Instructor:
                    return new Instructor();
            }
            return null;
        }
    }
}
