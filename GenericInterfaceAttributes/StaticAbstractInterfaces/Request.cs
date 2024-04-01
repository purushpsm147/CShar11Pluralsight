namespace GenericInterfaceAttributes.StaticAbstractInterfaces;

public class Request
{
    public void DoRequest<T>() where T : IRequestConfig
    {
        var url = T.absUrl;
        var method = T.HttpMethod;
        //Do something
        //Saves us from constantly having to new up objects
    }
}
