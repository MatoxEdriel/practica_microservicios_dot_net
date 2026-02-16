namespace Intercore.shared.Helpers;

public static class StringExtensions
{

    public static string ToCanonical(this string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return string.Empty;
        return text.Trim().ToLowerInvariant();
    }
}