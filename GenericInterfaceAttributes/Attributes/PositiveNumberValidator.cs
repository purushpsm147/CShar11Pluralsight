namespace GenericInterfaceAttributes.Attributes;

public class PositiveNumberValidator : IValidator<int>
{
    public bool Validate(int input)
    {
        return input > 0;
    }
}
