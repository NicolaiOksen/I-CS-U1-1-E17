public class Die
{
    private int numberOfEyes;
    private Random randomNumberSupplier;
    private readonly int maxNumberOfEyes;

    public Die(int numberOfEyes)
    {
        maxNumberOfEyes = numberOfEyes;
        randomNumberSupplier = new Random();
        numberOfEyes = NewTossHowManyEyes();
    }

    public Die() : this(6) { }

    public void Toss()
    {
        numberOfEyes = NewTossHowManyEyes();
    }

    private int NewTossHowManyEyes()
    {
        return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
    }

    public int NumberOfEyes()
    {
        return numberOfEyes;
    }

    public override String ToString()
    {
        return String.Format("[{0}]", numberOfEyes);
    }
}