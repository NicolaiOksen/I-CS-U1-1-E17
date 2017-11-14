public class Person
{
    public string FirstName { get; }
    public string SurName { get; }
    public Gender Gender { get; }
    public int Age { get; private set; }

    public Person(string firstName, string surName, Gender gender, int age)
    {
        FirstName = firstName;
        SurName = surName;
        Gender = gender;
        Age = age;
    }

    public int IncreaseAgeByOne()
    {
        Age++;
        return Age;
    }
}

public enum Gender
{
    Male, Female
}


public static void Main()
{ 
    string str = "5" + "\n" + 
                 "5,5" + "\n" +
                 "5555,0" + "\n" +
                 "false";

    using(TextReader tr = new StringReader(str))
    {
        int i = Int32.Parse(tr.ReadLine()); 
        double d = Double.Parse(tr.ReadLine());  
        decimal m = Decimal.Parse(tr.ReadLine());  
        bool b = Boolean.Parse(tr.ReadLine());

        Console.WriteLine("{0} \n{1} \n{2} \n{3}", i, d, m, b);
    }
}