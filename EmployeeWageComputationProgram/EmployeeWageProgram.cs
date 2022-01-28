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
            const int PRESENT = 1, ABSENT = 0,WAGE_PER_HOUR=20, FULL_DAY_HOUR=8;
            Random random = new Random(); 
           int check = random.Next(0, 2);
            if (check == PRESENT)
            {
                Console.WriteLine("Employee is Present \n");
                int dailywage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine("The Daily Wage Of the Employee is : {0}", dailywage);
            }
            if (check == ABSENT)
            {
                Console.WriteLine("Employee is Absent \n");
            }

        }

    }
}
