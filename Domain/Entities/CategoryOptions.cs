namespace Domain.Entities;

public class CategoryOptions : BaseEntity
{
    public int Id { get; set; }

    public int OptionResponseId { get; set; }
    public int CategoriesCatalogId { get; set; }

    public CategoriesCatalog? CategoriesCatalog { get; set; }
    public OptionsResponses? OptionsResponses { get; set; }
}
