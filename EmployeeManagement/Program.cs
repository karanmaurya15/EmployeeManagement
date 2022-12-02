namespace EmployeeManagement
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyEmpWage("Airtel", 30, 20, 100);
            empWageBuilder.addcompanyEmpWage("TCS", 40, 20, 200);
            empWageBuilder.addcompanyEmpWage("Wipro", 25, 20, 120);
            empWageBuilder.addcompanyEmpWage("Cipla", 20, 20, 150);
            empWageBuilder.ComputeEmpWage();
        }
    }
}