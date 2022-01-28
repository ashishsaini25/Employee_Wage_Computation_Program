using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    public class EmployeeWageProgram
    {
        public void Attendence()
        {
            const int PRESENT = 1, ABSENT = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == PRESENT)
            {
                Console.WriteLine("Employee is Present\n");
            }
            if (check == ABSENT)
            {
                Console.WriteLine("Employee is Absent\n");
            }

        }

    }
}
