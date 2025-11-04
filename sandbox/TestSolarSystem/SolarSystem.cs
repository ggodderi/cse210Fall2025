
class SolarSystem
{
    public List<Planet> _planets = new List<Planet>();

    public void DisplaySolarSystem()
    {
        Console.WriteLine("Solar System consists of the following planets");
        int planetCount = 0;
        foreach(Planet p in _planets)
        {
            planetCount++;
            Console.Write($"{planetCount}: ");
            p.DisplayPlanetInformation();
        }
    }
}