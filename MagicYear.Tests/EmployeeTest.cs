using Xunit;

namespace MagicYear.Tests;

public class Employee_MonthlySalaryShould
{
    [Fact]
    public void MonthlySalary_ReturnsRoundNumber_WhenAnnualSalaryDivisibleByTwelve()
    {
        //Arrange
        var john = new Employee("John", "MacDuff", 120000, 1960);
        var expected = 10000;

        //Act
        var actual = john.MonthlySalary();

        //Assert
        Assert.Equal(expected, actual);
    }
}