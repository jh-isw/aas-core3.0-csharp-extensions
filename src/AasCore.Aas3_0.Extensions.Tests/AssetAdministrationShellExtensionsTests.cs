namespace AasCore.Aas3_0.Extensions.Tests;

public class AssetAdministrationShellExtensionsTests
{
    internal static string ID = "https://example.com/id/123";
    
    [Test]
    public void Given_AAS_When_AddSubmodelReference_Then_ReferenceType_ModelReference()
    {
        // Arrange
        var submodel = new Submodel(ID);
        var ut = new AssetAdministrationShell("don't_care", new AssetInformation(AssetKind.Instance));
        
        // Act
        ut.AddSubmodelReference(submodel);
        
        // Assert
        Assert.That(ut.Submodels![0].Type, Is.EqualTo(ReferenceTypes.ModelReference));
    }

    [Test]
    public void Given_AAS_When_AddSubmodelReference_Then_Id_matches()
    {
        // Arrange
        var submodel = new Submodel(ID);
        var ut = new AssetAdministrationShell("don't_care", new AssetInformation(AssetKind.Instance));
        
        // Act
        ut.AddSubmodelReference(submodel);
        
        // Assert
        Assert.That(ut.Submodels![0].Keys[0].Value, Is.EqualTo(ID));
    }
    
    [Test]
    public void Given_AAS_When_AddSubmodelReference_Then_KeyTyps_Submodel()
    {
        // Arrange
        var submodel = new Submodel(ID);
        var ut = new AssetAdministrationShell("don't_care", new AssetInformation(AssetKind.Instance));
        
        // Act
        ut.AddSubmodelReference(submodel);
        
        // Assert
        Assert.That(ut.Submodels![0].Keys[0].Type, Is.EqualTo(KeyTypes.Submodel));
    }
}