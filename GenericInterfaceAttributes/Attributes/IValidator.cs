namespace GenericInterfaceAttributes.Attributes;

public interface IValidator<T>
{
    bool Validate(T input);
}
