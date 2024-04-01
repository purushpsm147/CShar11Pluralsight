// See https://aka.ms/new-console-template for more information
using GenericInterfaceAttributes.StaticAbstractInterfaces;

Console.WriteLine("Hello, World!");

var baseUrl = IRequestConfig.Url;

//below can be done with DI container
var request = new Request();
request.DoRequest<GetRequestToSomeURL>();