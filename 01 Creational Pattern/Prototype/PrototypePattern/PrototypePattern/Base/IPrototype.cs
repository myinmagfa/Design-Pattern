namespace PrototypePattern.Person;

public interface IPrototype
{
    Person ShallowCopy();

    Person DeepCopy();
}