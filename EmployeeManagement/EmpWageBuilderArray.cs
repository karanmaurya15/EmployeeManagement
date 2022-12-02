using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2; 

       
        private List<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> empWageDictionary;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new List<CompanyEmpWage>();
            this.empWageDictionary = new Dictionary<string, CompanyEmpWage>();
        }

        public void addcompanyEmpWage(string companyname, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyname, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.Add(companyEmpWage);
            this.empWageDictionary.Add(companyname, companyEmpWage);
        }
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
          
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
           
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + " Emp Hrs : " + empHrs);
               
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
        public int getTotalWage(string companyname)
        {
            return this.empWageDictionary[companyname].totalEmpWage;
        }

    }
}
