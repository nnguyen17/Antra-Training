using DesignAndBuildClassesUsingOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public class Dashboard
    {
        Menu menu;
        Choose choose;
        public Dashboard()
        {
            menu = new Menu();
            choose = new Choose();
        }
        public void Run()
        {
            int choice = menu.Print();
            Person c = choose.GetObject(choice);
            c.Infor();
        }

    }
}
