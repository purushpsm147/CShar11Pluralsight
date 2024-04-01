namespace GenericInterfaceAttributes.Attributes;

public class MapPoint
{
    [Validate<CityValidator, string>(new CityValidator())]
    public string NearestCity { get; set; }
    [Validate<CoordinateValidator, string>(new CoordinateValidator())]
    public string GpsCoordinates { get; set; }
}
