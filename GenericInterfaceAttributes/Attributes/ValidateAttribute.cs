﻿namespace GenericInterfaceAttributes.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ValidateAttribute<T> : Attribute where T : IValidator
{
    public T Validator { get; }
}
