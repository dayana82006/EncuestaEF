namespace Domain.Entities;

public class Questions : BaseEntity
{
    public int Id { get; set; }
    public int ChapterId { get; set; }
    public string QuestionNumber { get; set; }
    public string ResponseType { get; set; }
    public string CommentQuestion { get; set; }
    public string QuestionText { get; set; }

    public Chapters? Chapters { get; set; }
    public ICollection<OptionsQuestions>? OptionsQuestions { get; set; }


}
