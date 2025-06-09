namespace Domain.Entities;

public class CategoriesCatalog : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<CategoryOptions> CategoryOptions { get; set; }
    public ICollection<OptionsQuestions> OptionsQuestions { get; set; }
}
