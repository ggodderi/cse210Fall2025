class Planet
{
    public string _name = "";
    public int _numberOfDaysInAYear = 0;
    public double _semiMajorAxis = 0.0;
    public double _semiMinorAxis = 0.0;

    public void DisplayPlanetInformation()
    {
        Console.WriteLine($"Planet: {_name}, year length {_numberOfDaysInAYear} days, major axis {_semiMajorAxis}, minor axis {_semiMinorAxis} ");
    }
}