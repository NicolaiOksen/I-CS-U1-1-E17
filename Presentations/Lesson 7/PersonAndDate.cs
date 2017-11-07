using System;

[Serializable]
public class Person
{

    private string name;
    private int age;    // Redundant
    private Date dateOfBirth, dateOfDeath;

    public Person(string name, Date dateOfBirth)
    {
        this.name = name;
        this.dateOfBirth = dateOfBirth;
        this.dateOfDeath = null;
        age = Date.Today.YearDiff(dateOfBirth);
    }

    public Date DateOfBirth => new Date(dateOfBirth);

    public int Age => Alive ? age : dateOfDeath.YearDiff(dateOfBirth);

    public bool Alive => dateOfDeath == null;

    public void Died(Date d)
    {
        dateOfDeath = d;
    }

    public void Update()
    {
        age = Date.Today.YearDiff(dateOfBirth);
    }

    public override string ToString()
    {
        return "Person: " + name +
                "  *" + dateOfBirth +
                (Alive ? "" : "  +" + dateOfDeath) +
                "  Age: " + age;
    }

    public static void Main()
    {
        Person p = new Person("Peter", new Date(1936, 5, 11));
        p.Died(new Date(2007, 5, 10));
        Console.WriteLine("{0}", p);

        using (FileStream strm =
            new FileStream("person.dat", FileMode.Create))
        {
            IFormatter fmt = new BinaryFormatter();
            fmt.Serialize(strm, p);
        }

        // -----------------------------------------------------------
        p = null;
        Console.WriteLine("Reseting person");
        // -----------------------------------------------------------

        using (FileStream strm =
            new FileStream("person.dat", FileMode.Open))
        {
            IFormatter fmt = new BinaryFormatter();
            p = fmt.Deserialize(strm) as Person;
        }

        Console.WriteLine("{0}", p);
    }
}

[Serializable]
public class Date
{
    private ushort year;
    private byte month, day;
    private DayOfWeek nameOfDay;    // Redundant

    public Date(int year, int month, int day)
    {
        this.year = (ushort)year;
        this.month = (byte)month;
        this.day = (byte)day;
        this.nameOfDay = (new DateTime(year, month, day)).DayOfWeek;
    }

    public Date(Date d)
    {
        this.year = d.year; this.month = d.month;
        this.day = d.day; this.nameOfDay = d.nameOfDay;
    }

    public int Year => year;
    public int Month => month;
    public int Day => day;

    // return this minus other, as of usual birthday calculations.
    public int YearDiff(Date other)
    {
        if (this.Equals(other))
            return 0;
        if ((new Date(other.year, this.month, this.day)).IsBefore(other))
            return this.year - other.year - 1;
        return this.year - other.year;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        if (this.GetType() != obj.GetType())
            return false;
        if (ReferenceEquals(this, obj))
            return true;
        return this.year == ((Date)obj).year &&
                this.month == ((Date)obj).month &&
                this.day == ((Date)obj).day;
    }

    // Is this date less than other date
    public bool IsBefore(Date other)
    {
        return
            this.year < other.year ||
            this.year == other.year && this.month < other.month ||
            this.year == other.year && this.month == other.month && this.day < other.day;
    }


    public static Date Today
    {
        get
        {
            DateTime now = DateTime.Now;
            return new Date(now.Year, now.Month, now.Day);
        }
    }

    public override string ToString()
    {
        return string.Format("{0} {1}.{2}.{3}", nameOfDay, day, month, year);
    }
}