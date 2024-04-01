namespace GenericInterfaceAttributes.Attributes;

public class MapPoint
{
    [Validate<CityValidator, string>]
    public string NearestCity { get; set; }
    [Validate<CoordinateValidator, string>]
    public string GpsCoordinates { get; set; }

    [Validate<PositiveNumberValidator, int>]
    public int Altitude { get; set; }
}
