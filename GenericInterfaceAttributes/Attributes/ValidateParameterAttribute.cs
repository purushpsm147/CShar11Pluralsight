namespace GenericInterfaceAttributes.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class ValidateParameterAttribute : Attribute
{
    private readonly string _ParameterName;

    public ValidateParameterAttribute(string parameterName)
    {
        _ParameterName = parameterName;
    }
}
