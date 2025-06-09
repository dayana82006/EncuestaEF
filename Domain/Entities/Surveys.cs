namespace Domain.Entities;

public class Surveys : BaseEntity
{
    public int Id { get; set; }

    public string ComponentHtml { get; set; }
    public string ComponentReact { get; set; }
    public string Description { get; set; }
    public string Instruction { get; set; }
    public string Name { get; set; }
    public ICollection<Chapters> Chapters { get; set; } 
    public ICollection<SumaryOptions> SumaryOptions { get; set; }
}
