using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildClassesUsingOOP
{
    public interface IStudentService: IPersonService
    {
        public int NumOfCourse { get; set; }
        public double GPA();
        public char Grade { get; set; }
    }
}
