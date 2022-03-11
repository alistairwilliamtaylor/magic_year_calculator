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

    [Fact]
    public void MonthlySalary_ReturnsRoundNumber_WhenMonthlySalaryRoundedDown()
    {
        //Arrange
        var john = new Employee("John", "MacDuff", 120001, 1960);
        var expected = 10000;

        //Act
        var actual = john.MonthlySalary();

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MonthlySalary_ReturnsRoundNumber_WhenMonthlySalaryRoundedUp()
    {
        //Arrange
        var john = new Employee("John", "MacDuff", 120011, 1960);
        var expected = 10001;

        //Act
        var actual = john.MonthlySalary();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void MonthlySalary_RoundsUp_WhenExactlyHalfADollar()
    {
        //Arrange
        var john = new Employee("John", "MacDuff", 120006, 1960);
        var expected = 10001;

        //Act
        var actual = john.MonthlySalary();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void MagicYear_ReturnsYearStartedPlusSixtyfive_WhenEmployeeSpecifiesStartingYear()
    {
        //Arrange
        var john = new Employee("John", "MacDuff", 60000, 1960);
        var expected = 2025;

        //Act
        var actual = john.MagicYear();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Name_ReturnsSpaceSeparatedFirstAndLastName_WhenBothNamesSuppliedToConstructor()
    {
        //Arrange
        var john = new Employee("John", "MacDuff", 60000, 1960);
        var expected = "John MacDuff";

        //Act
        var actual = john.Name;

        //Assert
        Assert.Equal(expected, actual);
    }

}