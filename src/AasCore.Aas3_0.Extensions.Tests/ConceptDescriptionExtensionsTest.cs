namespace AasCore.Aas3_0.Extensions.Tests;

public class ConceptDescriptionExtensionsTest
{
    private static string ID = "https://example.com/id/123456789";
    
    [Test]
    public void ToModelReference_GivesCorrectReferenceType()
    {
        // Arrange
        var cd = new ConceptDescription(ID);
        
        // Act
        var reference = cd.ToModelReference();
        
        // Assert
        Assert.That(reference.Type, Is.EqualTo(ReferenceTypes.ModelReference));
    }
    
    [Test]
    public void ToModelReference_GivesKeysCount1()
    {
        // Arrange
        var cd = new ConceptDescription(ID);
        
        // Act
        var reference = cd.ToModelReference();
        
        // Assert
        Assert.That(reference.Keys.Count, Is.EqualTo(1));
    }
    
    [Test]
    public void ToModelReference_GivesCorrectKeyType()
    {
        // Arrange
        var cd = new ConceptDescription(ID);
        
        // Act
        var reference = cd.ToModelReference();
        
        // Assert
        Assert.That(reference.Keys[0].Type, Is.EqualTo(KeyTypes.ConceptDescription));
    }
    
    [Test]
    public void ToModelReference_GivesCorrectId()
    {
        // Arrange
        var cd = new ConceptDescription(ID);
        
        // Act
        var reference = cd.ToModelReference();
        
        // Assert
        Assert.That(reference.Keys[0].Value, Is.EqualTo(ID));
    }
}