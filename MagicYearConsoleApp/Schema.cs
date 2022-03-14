public class PromptSchema
{
    public static Dictionary<string, string> GetFirstNameSchema()
    {
        var firstNameSchema = new Dictionary<string, string>
        {
            {"prompt", "Please input your name: "},
            {"pattern", @"^[a-zA-Z\s\-]+$"},
            {"errorMessage", "Please try again. Your name may only contain letters, spaces, or dashes."}
        };
        return firstNameSchema;
    }

    public static Dictionary<string, string> GetSurnameSchema()
    {
        var surnameSchema = new Dictionary<string, string>
        {
            {"prompt", "Please input your surname: "},
            {"pattern", @"^[a-zA-Z\s\-]+$"},
            {"errorMessage", "Please try again. Your surname may only contain letters, spaces, or dashes."}
        };
        return surnameSchema;
    }
    
    public static Dictionary<string, string> GetSalarySchema()
    {
        var salarySchema = new Dictionary<string, string>
        {
            {"prompt", "Please enter your annual salary: "},
            {"pattern", @"^[0-9]+$"},
            {"errorMessage", "Please try again. Your salary must be a positive integer."}
        };
        return salarySchema;
    }
    
    public static Dictionary<string, string> GetWorkStartYearSchema()
    {
        var currentYear = DateTime.Now.Year;
        var workStartSchema = new Dictionary<string, string>
        {
            {"prompt", "Please enter your work start year: "},
            {"pattern", @"^(19|20)\d{2}$"},
            {"errorMessage", $"Please try again. Your work start year must be between 1900 and {currentYear}."}
        };
        return workStartSchema;
    }
}