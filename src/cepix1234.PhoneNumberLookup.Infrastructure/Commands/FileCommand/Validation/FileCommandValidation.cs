using System.Text.RegularExpressions;
using Spectre.Console;
using Spectre.Console.Cli;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Commands.FileCommand.Validation;

public class FileCommandValidation : ParameterValidationAttribute
{
    #nullable disable
    public FileCommandValidation() : base(errorMessage: null)
    {
    }
    #nullable enable

    public override ValidationResult Validate(CommandParameterContext context)
    {
        if (context.Value is string)
        {
            bool pathExist = File.Exists(context.Value.ToString());
            Match fileFormatCorrect = Regex.Match(context.Value.ToString() ?? string.Empty, ".*\\.txt", RegexOptions.IgnoreCase);

            if (!pathExist)
            {
                return ValidationResult.Error($"{context.Parameter.PropertyName} ({context.Value}) path does not exist.");
            }

            if (!fileFormatCorrect.Success)
            {
                return ValidationResult.Error(
                    $"{context.Parameter.PropertyName} ({context.Value}) specified file must be in .txt format.");
            }
            return ValidationResult.Success();
        }
        return ValidationResult.Error($"{context.Parameter.PropertyName} ({context.Value}) needs to be a string.");
    }
}