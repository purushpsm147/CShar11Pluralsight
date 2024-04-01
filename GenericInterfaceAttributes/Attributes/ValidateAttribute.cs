namespace GenericInterfaceAttributes.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ValidateAttribute<TValidator, TProperty> : Attribute where TValidator : IValidator<TProperty>
{
    public TValidator Validator { get; }
    public ValidateAttribute(TValidator validator)
    {
        Validator = validator;
    }
}
