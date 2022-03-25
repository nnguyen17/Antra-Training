using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public interface IIntructorService : IPersonService
    {
        public string Department { get; set; }
        public bool IsHead { get; set; }
        public decimal Salary();

    }
}
