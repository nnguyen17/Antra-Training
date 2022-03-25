using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public interface IDepartmentService
    {
        public string Head { get; set; }
        public decimal Budget { get; set; } 
        public string Courses { get; set; }
    }
}
