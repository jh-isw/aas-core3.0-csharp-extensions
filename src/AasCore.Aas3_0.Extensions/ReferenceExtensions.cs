namespace AasCore.Aas3_0.Extensions;

public static class ReferenceExtensions
{
    /// <summary>
    /// Returns a Reference of ReferenceTypes.External with one Key of KeyTypes.GlobalReference
    /// and value = "http://admin-shell.io/DataSpecificationTemplates/DataSpecificationIEC61360/2/0"
    /// </summary>
    /// <returns></returns>
    public static Reference GetDataSpecificationIec61360Reference()
    {
        return new Reference(
            ReferenceTypes.ExternalReference,
            new List<IKey>(1)
            {
                new Key(KeyTypes.GlobalReference,
                    "http://admin-shell.io/DataSpecificationTemplates/DataSpecificationIEC61360/2/0")
            });
    }
}