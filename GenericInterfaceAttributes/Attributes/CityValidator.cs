namespace GenericInterfaceAttributes.Attributes;

internal class CityValidator : IValidator
{
    public bool Validate(string input)
    {
        //uppercase only, max 20 characters
        if(!(input.ToUpper() == input))
        {
            return false;
        }
        if(input.Length > 20)
        {
            return false;
        }
        return true;
    }
}
