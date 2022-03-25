using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public interface IPersonService
    {
        public int Age();
        public decimal Salary();
        public string Address();
    }
}
