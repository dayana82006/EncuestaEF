namespace ApiP.DTOs.OptionQuestions;
public class OptionQuestionDto
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public int OptionId { get; set; }
    public int OptionCatalogId { get; set; }
    public int OptionQuestionId { get; set; }
    public string? CommentOptionres { get; set; }
    public string? NumberOption { get; set; }

    public int QuestionId { get; set; }
    public string? QuestionText { get; set; }

    public int SubquestionId { get; set; }
    public string? SubQuestionText { get; set; }

    public int CategoriesCatalogId { get; set; }
    public string? CategoryName { get; set; }

    public int OptionsResponseId { get; set; }
    public string? ResponseText { get; set; }
}
