using MagicYear;

System.Console.WriteLine("Welcome to the magic year calculator!\n");

var firstNameSchema = PromptSchema.GetFirstNameSchema();
var firstName = InputValidation.GetValidInput(firstNameSchema);
var surnameSchema = PromptSchema.GetSurnameSchema();
var surname = InputValidation.GetValidInput(surnameSchema);
var salarySchema = PromptSchema.GetSalarySchema();
var salaryInput = InputValidation.GetValidInput(salarySchema);
var salary = int.Parse(salaryInput);
var workStartSchema = PromptSchema.GetWorkStartYearSchema();
var workStartYearInput = InputValidation.GetValidInput(workStartSchema);
var workStartYear = int.Parse(workStartYearInput);

var userEmployee = new Employee(firstName, surname, salary, workStartYear);

System.Console.WriteLine("\nYour magic age details are:\n");

System.Console.WriteLine($"Name: {userEmployee.Name}");
System.Console.WriteLine($"Monthly Salary: {userEmployee.MonthlySalary()}");
System.Console.WriteLine($"Magic Year: {userEmployee.MagicYear()}");