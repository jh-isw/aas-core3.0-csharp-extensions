namespace AasCore.Aas3_0.Extensions;

public static class ConceptDescriptionExtensions
{
    public static Reference ToModelReference(this ConceptDescription cd)
    {
        return new Reference(
            ReferenceTypes.ModelReference,
            new List<IKey>(1)
            {
                new Key(KeyTypes.ConceptDescription,
                    cd.Id)
            });
    }
}