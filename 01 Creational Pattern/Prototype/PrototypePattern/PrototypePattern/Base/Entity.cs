namespace PrototypePattern.Base;

public class Entity<T>
{
    public T Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}