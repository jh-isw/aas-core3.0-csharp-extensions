namespace AasCore.Aas3_0.Extensions.Tests;

public class ReferableExtensionsTests
{
    [Test]
    public void IsValidIdShort_ValidString_ReturnsTrue()
    {
        string validStr = "ValidString1";
        bool result = ReferableExtensions.IsValidIdShort(validStr);

        Assert.IsTrue(result);
    }

    [Test]
    public void IsValidIdShort_EmptyString_ReturnsFalse()
    {
        string emptyStr = "";
        bool result = ReferableExtensions.IsValidIdShort(emptyStr);

        Assert.IsFalse(result);
    }

    [Test]
    public void IsValidIdShort_LongString_ReturnsFalse()
    {
        string longStr = new string('a', 129);
        bool result = ReferableExtensions.IsValidIdShort(longStr);

        Assert.IsFalse(result);
    }

    [Test]
    public void IsValidIdShort_InvalidCharacters_ReturnsFalse()
    {
        string invalidStr = "\u007f";
        bool result = ReferableExtensions.IsValidIdShort(invalidStr);

        Assert.IsFalse(result);
    }
    
    [Test]
    public void IsValidIdShort_FirstCharacterNotAlpha_ReturnsFalse()
    {
        string str = "1nvalidString";
        bool result = ReferableExtensions.IsValidIdShort(str);

        Assert.IsFalse(result);
    }
}