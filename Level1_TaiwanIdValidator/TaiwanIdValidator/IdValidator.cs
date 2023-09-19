using System.Text.RegularExpressions;

namespace TaiwanIdValidator;

public partial class IdValidator
{
    private readonly IDictionary<char, int> _cityCodes = new Dictionary<char, int>
    {
        { 'A', 10 }, { 'B', 11 }, { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 },
        { 'G', 16 }, { 'H', 17 }, { 'J', 18 }, { 'K', 19 }, { 'L', 20 }, { 'M', 21 },
        { 'N', 22 }, { 'P', 23 }, { 'Q', 24 }, { 'R', 25 }, { 'S', 26 }, { 'T', 27 },
        { 'U', 28 }, { 'V', 29 }, { 'X', 30 }, { 'W', 31 }, { 'Y', 32 }, { 'Z', 33 },
        { 'I', 34 }, { 'O', 35 }
    };

    private readonly int[] _weights = { 1, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

    /// <summary>
    /// Validate Taiwan ID
    /// </summary>
    /// <param name="id">taiwan id</param>
    /// <returns>Validation result</returns>
    public (bool IsValid, string ErrorMessage) Validate(string id)
    {
        if (IsValidLength(id) == false)
        {
            return (false, "ID must be 10 characters long.");
        }

        id = id.ToUpper();

        if (IsValidFormat(id) == false)
        {
            return (false, "ID format is incorrect.");
        }

        if (IsValidCityCode(id[0]) == false)
        {
            return (false, "Invalid city code.");
        }

        if (IsValidChecksum(id) == false)
        {
            return (false, "Checksum validation failed.");
        }

        return (true, "ID is valid.");
    }

    private bool IsValidLength(string id) => string.IsNullOrEmpty(id) == false && id.Length == 10;

    private bool IsValidFormat(string id) => TaiwanIdRegex().IsMatch(id);

    private bool IsValidCityCode(char cityCode) => _cityCodes.ContainsKey(cityCode);

    private bool IsValidChecksum(string id)
    {
        var cityCode = _cityCodes[id[0]];

        var sum = cityCode / 10 * _weights[0] + cityCode % 10 * _weights[1];
        for (var i = 1; i <= 8; i++)
        {
            sum += (int)char.GetNumericValue(id[i]) * _weights[i + 1];
        }

        sum += (int)char.GetNumericValue(id[9]); // last digit is checksum, so no weight

        return sum % 10 == 0;
    }

    [GeneratedRegex("^[A-Z][1289][0-9]{8}$")]
    private static partial Regex TaiwanIdRegex();
}