namespace HW10_sequences;

public record Entity(int Id, int ParentId, string Name)
{
    public override string ToString() => $"Entity{{Id = {Id}}}";
}