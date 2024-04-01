using System.Text.RegularExpressions;

namespace GenericInterfaceAttributes.StaticAbstractInterfaces;

public partial class GetRequestToSomeURL : IRequestConfig
{
    public static string absUrl => "https://someOtherUrl.com";

    public static HttpMethod HttpMethod => HttpMethod.Get;

    public static bool checkUrl()
    {
        //Check for Valid Url.
        var result  = URLChecker().Match(absUrl);
        return result.Success;

    }

    [GeneratedRegex(@"(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?")]
    private static partial Regex URLChecker();
}
