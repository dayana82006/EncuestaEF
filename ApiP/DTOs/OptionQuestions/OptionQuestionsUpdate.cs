namespace ApiP.DTOs.OptionQuestions;

public class UpdateOptionQuestionDto
{
    public int Id { get; set; }
    public int OptionId { get; set; }
    public int OptionCatalogId { get; set; }
    public int OptionQuestionId { get; set; }
    public string? CommentOptionres { get; set; }
    public string? NumberOption { get; set; }

    public int QuestionId { get; set; }
    public int SubquestionId { get; set; }
    public int CategoriesCatalogId { get; set; }
    public int OptionsResponseId { get; set; }
}
