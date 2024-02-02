using System.ComponentModel;
using Spectre.Console.Cli;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Commands.NumberCommand.Settings;
public class NumberCommandSettings : CommandSettings
{
    [CommandArgument(0, "<PhoneNumber>")]
    [Description("Phone number to lookup")]
    public string PhoneNumber { get; set; } = string.Empty;
}