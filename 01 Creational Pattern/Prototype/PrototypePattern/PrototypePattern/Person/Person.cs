using PrototypePattern.Base;

namespace PrototypePattern.Person;

public class Person : Entity<int>,IEqualityComparer<Person>, IPrototype
{
    public int Age;
    public DateTime BirthDate;
    public IdInfo IdInfo;
    public string Name;

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        return clone;
    }

    public bool Equals(Person x, Person y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.Id == y.Id && x.CreatedAt.Equals(y.CreatedAt) && x.ModifiedAt.Equals(y.ModifiedAt) && x.Age == y.Age && x.BirthDate.Equals(y.BirthDate) && x.IdInfo.Equals(y.IdInfo) && x.Name == y.Name;
    }

    public int GetHashCode(Person obj)
    {
        return HashCode.Combine(obj.Id, obj.CreatedAt, obj.ModifiedAt, obj.Age, obj.BirthDate, obj.IdInfo, obj.Name);
    }
}