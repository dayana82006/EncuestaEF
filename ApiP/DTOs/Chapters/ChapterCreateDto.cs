namespace ApiP.DTOs.Chapters;

public class ChapterCreateDto
{
    public int SurveyId { get; set; }
    public string? ComponentHtml { get; set; }
    public string? ComponentReact { get; set; }
    public string? ChapterNumber { get; set; }
    public string? ChapterTitle { get; set; }
}
