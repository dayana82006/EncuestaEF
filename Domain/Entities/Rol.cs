namespace Domain.Entities;

public class Rol : BaseEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public List<Member> Member { get; set; } = new List<Member>();
           public ICollection<MemberRols> MemberRols { get; set; } = new HashSet<MemberRols>();
    
}