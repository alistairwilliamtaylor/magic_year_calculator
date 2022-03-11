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
                var monthlySalary = Math.Round((float)annualSalary / 12f, MidpointRounding.AwayFromZero);
                return (int)monthlySalary;
            }

            public int MagicYear()
            {
                throw new NotImplementedException("not implemented yet");
            }

        }
}
