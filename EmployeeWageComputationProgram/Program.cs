using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
          EmployeeWageProgram company1 = new EmployeeWageProgram();
            company1.Attendence(100,25,100);
            EmployeeWageProgram company2 = new EmployeeWageProgram();
            company2.Attendence(100, 25, 50);
            EmployeeWageProgram company3 = new EmployeeWageProgram();
            company3.Attendence(90, 25, 200);
            EmployeeWageProgram company4 = new EmployeeWageProgram();
            company4.Attendence(100, 25, 100);

        }
    }
}
