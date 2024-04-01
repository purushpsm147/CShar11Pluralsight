namespace GenericInterfaceAttributes.Attributes;

public class MapPoint
{
    [Validate<CityValidator>]
    public string NearestCity { get; set; }
    [Validate<CoordinateValidator>]
    public string GpsCoordinates { get; set; }
}
