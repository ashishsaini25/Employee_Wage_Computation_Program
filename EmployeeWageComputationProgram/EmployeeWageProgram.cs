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
            const int PART_TIME = 0, FULL_TIME = 1, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4, WORKING_DAYS = 20,MAX_WORK_HOUR=100;
            int monthlywage = 0;
            int workinghour = 0;
            Random random = new Random();
            for (int i = 0; i < WORKING_DAYS&&MAX_WORK_HOUR>=workinghour; i++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case PART_TIME:
                        monthlywage += WAGE_PER_HOUR * PART_TIME_HOUR;
                        workinghour += PART_TIME_HOUR;
                        break;
                    case FULL_TIME:
                        monthlywage += WAGE_PER_HOUR * FULL_DAY_HOUR;
                        workinghour += FULL_DAY_HOUR;
                        break;
                    default:
                        monthlywage += 0;
                        break;
                }
            }
            Console.WriteLine("The Monthly Wage Of the Employee is :{0} and Total Working hour was {1}", monthlywage,workinghour);

        }

    }
}
