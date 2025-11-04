class Program
{
    static void Main()
    {
        Planet p1 = new Planet();
        p1._name = "Mercury";
        p1._numberOfDaysInAYear = 243;
        p1._semiMinorAxis = 100;
        p1._semiMajorAxis = 120;

        Planet p2 = new Planet();
        p2._name = "Venus";
        p2._numberOfDaysInAYear = 293;
        p2._semiMinorAxis = 190;
        p2._semiMajorAxis = 210;

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._planets.Add(p1);
        solarSystem._planets.Add(p2);
        solarSystem.DisplaySolarSystem();
    }
}