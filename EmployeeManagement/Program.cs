namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program\n");
          
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 150;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();          
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is :" + empWage);
            

        }
    }
}