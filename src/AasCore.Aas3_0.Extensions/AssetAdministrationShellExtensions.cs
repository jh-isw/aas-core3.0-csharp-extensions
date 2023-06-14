namespace AasCore.Aas3_0.Extensions;

public static class AssetAdministrationShellExtensions
{
    public static void AddSubmodelReference(this AssetAdministrationShell shell, Submodel submodel)
    {
        if (shell.Submodels is null)
        {
            shell.Submodels = new List<IReference>();
        }
        
        shell.Submodels.Add(new Reference(ReferenceTypes.ModelReference, new List<IKey>(1)
        {
            new Key(KeyTypes.Submodel, submodel.Id)
        }));
    }
}