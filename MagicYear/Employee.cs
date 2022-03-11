using System;
namespace MagicYear
{
    public class Employee
        {
            public Employee(string firstName, string secondName, int salary, int startingYear)
            {
                name = firstName + secondName;
                annualSalary = salary;
                yearStarted = startingYear;
            }

            private string name;
            private int annualSalary;
            private int yearStarted;

            public int MonthlySalary()
            {
                return annualSalary / 12;
            }
        }
}
