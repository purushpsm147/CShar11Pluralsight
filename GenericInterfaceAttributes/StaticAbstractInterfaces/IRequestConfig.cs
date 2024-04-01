namespace GenericInterfaceAttributes.StaticAbstractInterfaces;

public interface IRequestConfig
{
    static string Url => "https://someurl.com";
    static abstract string absUrl {  get; }
    static abstract HttpMethod HttpMethod { get; }
    static abstract bool checkUrl();
}
