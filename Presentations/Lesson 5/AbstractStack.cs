public abstract class Stack
{
    public abstract void Push(object el);

    public abstract void Pop();

    public abstract object Top { get; }

    public abstract bool Full { get; }

    public abstract bool Empty { get; }

    public abstract int Size { get; }

    public void ToggleTop()
    {
        if (Size < 2) return;
        var topEl1 = Top; Pop();
        var topEl2 = Top; Pop();
        Push(topEl1); Push(topEl2);
    }

    public override string ToString()
    {
        return $"Stack[{Size}]";
    }
}

