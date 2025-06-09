namespace Domain.Entities;

public class SumaryOptions : BaseEntity
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public string CodeNumber { get; set; }

    public Surveys? Surveys { get; set; }
    
     
}
