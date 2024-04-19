using System;

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
}

class Builder : Human
{
    public string ConstructionSpecialty { get; set; }

    public void Build()
    {
        Console.WriteLine($"{Name} is a builder specializing in {ConstructionSpecialty}.");
    }
}

class Sailor : Human
{
    public string ShipType { get; set; }

    public void Sail()
    {
        Console.WriteLine($"{Name} is a sailor on a {ShipType}.");
    }
}

class Pilot : Human
{
    public string AircraftType { get; set; }

    public void Fly()
    {
        Console.WriteLine($"{Name} is a pilot flying a {AircraftType}.");
    }
}

class Passport
{
    public string FullName { get; set; }
    public string PassportNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class ForeignPassport : Passport
{
    public string VisaInformation { get; set; }
    public string PassportNumberForeign { get; set; }
}

class Program
{
    static void Main()
    {
        Builder builder = new Builder
        {
            Name = "John",
            Age = 35,
            Gender = "Male",
            ConstructionSpecialty = "Carpentry"
        };

        Sailor sailor = new Sailor
        {
            Name = "Alice",
            Age = 28,
            Gender = "Female",
            ShipType = "Sailboat"
        };

        Pilot pilot = new Pilot
        {
            Name = "Tom",
            Age = 40,
            Gender = "Male",
            AircraftType = "Boeing 747"
        };

        builder.Build();
        sailor.Sail();
        pilot.Fly();

        ForeignPassport human = new ForeignPassport
        {
            FullName = "Ivan Ivanov",
            PassportNumber = "445616546",
            DateOfBirth = new DateTime(1,2,2006),
            VisaInformation = "Euro",
            PassportNumberForeign = "544575454"
        };
            
    }
}
