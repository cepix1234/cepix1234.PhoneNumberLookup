using System.Text.Json.Serialization;
using cepix1234.PhoneNumberLookup.Core.Models.Interfaces;

namespace cepix1234.PhoneNumberLookup.Core.Models.NumberInfo;

public class NumberAssociatedEmailAddresses : IBaseObject
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("emails")]
    public string[]? Emails { get; set; }

    public override string ToString()
    {
        string emailsString = "";
        if (Emails != null)
            foreach (string email in Emails)
            {
                emailsString = $"{emailsString} {email}\n";
            }

        return $"{Status}: \n {emailsString}";
    }
}