public class Pair<T, TS>
{
    public Pair(T first, TS second)
    {
        this.First = first; this.Second = second;
    }

    public T First { get; }

    public TS Second { get; }
}