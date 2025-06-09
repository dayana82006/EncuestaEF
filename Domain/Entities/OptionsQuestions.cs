namespace Domain.Entities;

public class OptionsQuestions : BaseEntity
{

    public int Id { get; set; }    public int OptionId { get; set; }
    public int CategoriesCatalogId { get; set; }
    public int OptionQuestionId { get; set; }
    public int SubQuestionId { get; set; }
    public string CommentOptiones { get; set; }
    public string NumberOption { get; set; }

    public CategoriesCatalog? CategoriesCatalog { get; set; }
    public Questions? Questions { get; set; }
    public SubQuestions? SubQuestions { get; set; }
    public OptionsResponses? OptionsResponses { get; set; }

}
