public class FixedProperty
{
    protected string location;
    protected bool inCity;
    protected decimal estimatedValue;

    public FixedProperty(string location, bool inCity, decimal value)
    {
        this.location = location;
        this.inCity = inCity;
        this.estimatedValue = value;
    }

    public FixedProperty(string location) :
        this(location, true, 1000000)
    {
    }

    public string Location => location;
}

public class Vehicle
{
    protected int registrationNumber;
    protected double maxVelocity;
    protected decimal value;

    public Vehicle(int registrationNumber, double maxVelocity,
        decimal value)
    {
        this.registrationNumber = registrationNumber;
        this.maxVelocity = maxVelocity;
        this.value = value;
    }

    public int RegistrationNumber => registrationNumber;
}

public class Bus : Vehicle
{
    protected int numberOfSeats;

    public Bus(int numberOfSeats, int regNumber, decimal value) :
        base(regNumber, 80, value)
    {
        this.numberOfSeats = numberOfSeats;
    }

    public int NumberOfSeats => numberOfSeats;
}

public class House : FixedProperty
{
    protected double area;

    public House(string location, bool inCity, double area,
        decimal value) :
        base(location, inCity, value)
    {
        this.area = area;
    }

    public double Area => area;
}