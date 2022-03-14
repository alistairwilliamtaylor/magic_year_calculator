using System.Text.RegularExpressions;

public class InputValidation
{
    public static string GetValidInput(Dictionary<string, string> schema)
    {
        var validInput = PromptUntilValidInput(schema);
        return validInput;
    } 

    private static string PromptUntilValidInput(Dictionary<string, string> schema)
    {
        var userInput = string.Empty;
        while (true)
        {
            try
            {
                userInput = InputValidation.PromptUser(schema);
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return userInput;
    }

    private static string PromptUser(Dictionary<string, string> schema)
    {
        {
            System.Console.Write(schema["prompt"]);
            var userInput = Console.ReadLine();
            var validInput = Regex.IsMatch(userInput, schema["pattern"]);
            if (!validInput)
            {
                throw new Exception(schema["errorMessage"]);
            }
            return userInput;
        }
    }
}