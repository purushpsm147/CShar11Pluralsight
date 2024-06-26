﻿namespace GenericInterfaceAttributes.Attributes;

public class CoordinateValidator : IValidator<string>
{
    public bool Validate(string input)
    {
        if(!(input.ToLower() == input))
        {
            return false;
        }
        if(input.Length > 100)
        {
            return false;
        }
        return true;
    }
}
