using System;
namespace MagicYear
{
    public class Employee
        {
            private string FirstName;
            private string Surname;
            private int AnnualSalary;
            private int YearStarted;
            public Employee(string firstName, string surname, int salary, int startingYear)
            {
                FirstName = firstName;
                Surname = surname;
                AnnualSalary = salary;
                YearStarted = startingYear;
            }

            public int MonthlySalary()
            {
                var monthlySalary = Math.Round((float)AnnualSalary / 12f, MidpointRounding.AwayFromZero);
                return (int)monthlySalary;
            }

            public int MagicYear()
            {
                return YearStarted + 65;
            }

            public string Name()
            {
                return FirstName + " " + Surname;
            }
        }
}
