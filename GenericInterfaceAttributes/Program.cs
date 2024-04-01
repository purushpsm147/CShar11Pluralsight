// See https://aka.ms/new-console-template for more information
using GenericInterfaceAttributes.Attributes;
using GenericInterfaceAttributes.StaticAbstractInterfaces;
using System.Numerics;
using System.Reflection;

Console.WriteLine("Hello, World!");

var baseUrl = IRequestConfig.Url;

//below can be done with DI container
var request = new Request();
request.DoRequest<GetRequestToSomeURL>();

double[] doubles = { 1.0, 2.0, 3.0, 4.0, 5.0 };
//var sum = doubles.Sum();
var sum = AddAll(doubles);
int[] ints = { 1, 2, 3, 4, 5 };
//var sumInts = ints.Sum();
var sumInts = AddAll(ints);
Console.WriteLine($"Sum of doubles: {sum}");
Console.WriteLine($"Sum of ints: {sumInts}");

static T AddAll<T>(params T[] values) where T : INumber<T>
{
    T sum = T.Zero;
    T one = T.One;
    T max = T.Max(one, sum);
    T min = T.Min(one, sum);
    T abs = T.Abs(sum);
    foreach (var value in values)
    {
        sum += value;
    }
    return sum;
}

var mapPoint = new MapPoint
{
    NearestCity = "STOCKHOLM",
    GpsCoordinates = "59° 20' 4.5276'' N, 18° 3' 47.6640'' E"
};

var result = ValidateMapPoint(mapPoint);

bool ValidateMapPoint(MapPoint mapPoint)
{
    var cityValidator = GetValidator<MapPoint>(nameof(mapPoint.NearestCity));
    var nearestCityResult = cityValidator.Validate(mapPoint.NearestCity);

    var coordinateValidator = GetValidator<MapPoint>(nameof(mapPoint.GpsCoordinates));
    var gpsCoordinatesResult = coordinateValidator.Validate(mapPoint.GpsCoordinates);

    return nearestCityResult && gpsCoordinatesResult;
}

IValidator GetValidator<T>(string property)
{
    var validatorType = typeof(T)
                        .GetProperty(property)
                        .GetCustomAttributes(typeof(ValidateAttribute<>))
                        .GetType()
                        .GenericTypeArguments.First();

    return Activator.CreateInstance(validatorType) as IValidator;

}