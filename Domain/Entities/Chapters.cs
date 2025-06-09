namespace Domain.Entities;

public class Chapters : BaseEntity
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public string ComponentHtml { get; set; }
    public string ComponentReact { get; set; }
    public string ChapterNumber { get; set; }
    public string ChapterTitle { get; set; }
    public Surveys? Surveys { get; set; }
    public ICollection<Questions>? Questions { get; set; }
}

