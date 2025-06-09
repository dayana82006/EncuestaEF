namespace Domain.Entities;

public class SubQuestions : BaseEntity
{
    public int Id { get; set; }
    public int SubQuestionId { get; set; }
    public string SubQuestionNumber { get; set; }
    public string CommentSubQuestion { get; set; }
    public string SubQuestionText { get; set; }

    public ICollection<OptionsQuestions>? OptionsQuestions { get; set; }
}
