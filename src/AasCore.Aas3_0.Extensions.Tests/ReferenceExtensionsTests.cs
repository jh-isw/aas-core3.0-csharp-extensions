namespace AasCore.Aas3_0.Extensions.Tests;

public class ReferenceExtensionsTests
{
    [Test]
    public void GetDataSpecificationIec61360Reference_ReturnsExternalReferenceType()
    {
        // Arrange
        var expectedReferenceType = ReferenceTypes.ExternalReference;

        // Act
        var reference = ReferenceExtensions.GetDataSpecificationIec61360Reference();

        // Assert
        Assert.That(reference.Type, Is.EqualTo(expectedReferenceType));
    }

    [Test]
    public void GetDataSpecificationIec61360Reference_ReturnsOneKeyInListOfKeys()
    {
        // Arrange

        // Act
        var reference = ReferenceExtensions.GetDataSpecificationIec61360Reference();

        // Assert
        Assert.That(reference.Keys.Count, Is.EqualTo(1));
    }

    [Test]
    public void GetDataSpecificationIec61360Reference_ReturnsGlobalReferenceKeyType()
    {
        // Arrange
        var expectedKeyType = KeyTypes.GlobalReference;

        // Act
        var reference = ReferenceExtensions.GetDataSpecificationIec61360Reference();
        var key = reference.Keys[0];

        // Assert
        Assert.That(key.Type, Is.EqualTo(expectedKeyType));
    }

    [Test]
    public void GetDataSpecificationIec61360Reference_ReturnsExpectedKeyReference()
    {
        // Arrange
        var expectedKeyReference = "http://admin-shell.io/DataSpecificationTemplates/DataSpecificationIEC61360/2/0";

        // Act
        var reference = ReferenceExtensions.GetDataSpecificationIec61360Reference();
        var key = reference.Keys[0];

        // Assert
        Assert.That(key.Value, Is.EqualTo(expectedKeyReference));
    }
}