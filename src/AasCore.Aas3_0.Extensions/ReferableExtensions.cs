using System.Text.RegularExpressions;

namespace AasCore.Aas3_0.Extensions;

public static class ReferableExtensions
{
    public static bool IsValidIdShort(string str)
    {
        // Length criteria
        if (str.Length < 1 || str.Length > 128)
            return false;

        // Pattern criteria
        var regex1 = new Regex("^([\\t\\n\\r -\ud7ff\\ue000-\\ufffd]|\\ud800[\\udc00-\\udfff]|[\\ud801-\\udbfe][\\udc00-\\udfff]|\\udbff[\\udc00-\\udfff])*$");
        if (!regex1.IsMatch(str))
            return false;

        var regex2 = new Regex("^[a-zA-Z][a-zA-Z0-9_]*$");
        if (!regex2.IsMatch(str))
            return false;

        // All criteria have been met
        return true;
    }
}