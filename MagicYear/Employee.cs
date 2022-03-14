using System;
namespace MagicYear
{
    public class Employee
        {
            public Employee(string firstName, string surname, int salary, int startingYear)
            {
                Name = firstName + " " + surname;
                AnnualSalary = salary;
                YearStarted = startingYear;
            }

            public string Name {get; private set;}
            private int AnnualSalary;
            private int YearStarted;

            public int MonthlySalary()
            {
                var monthlySalary = Math.Round((float)AnnualSalary / 12f, MidpointRounding.AwayFromZero);
                return (int)monthlySalary;
            }

            public int MagicYear()
            {
                return YearStarted + 65;
            }
        }
}
