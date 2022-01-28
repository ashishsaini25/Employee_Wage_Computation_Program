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
            const int PART_TIME = 0, FULL_TIME = 1, ABSENT = 0, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4;
            int dailywage = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            switch (check)
            {
                case PART_TIME:
                    dailywage += WAGE_PER_HOUR * PART_TIME_HOUR;
                    break;
                case FULL_TIME:
                    dailywage += WAGE_PER_HOUR * FULL_DAY_HOUR;
                    break;
                default:
                    dailywage = 0;
                    break;
            }

            Console.WriteLine("The today Wage Of the Employee is :{0}", dailywage);

        }

    }
}
