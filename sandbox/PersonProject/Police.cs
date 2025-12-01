using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Channels;

class Police : Person
{
    private string _weapons = "";
    public Police(string weapons, string firstName, string lastName, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, Weapons: {_weapons}";
    }

    public override double GetSalary()
    {
        return 50000.23;
    }
    
}