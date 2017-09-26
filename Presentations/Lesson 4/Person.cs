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