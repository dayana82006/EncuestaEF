namespace Domain.Entities;

public class OptionsResponses : BaseEntity
{
    public int Id { get; set; }
    public string OptionText { get; set; }

    public ICollection<OptionsQuestions>? OptionsQuestions { get; set; }
}
