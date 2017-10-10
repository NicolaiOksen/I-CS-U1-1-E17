public class StackWithArray : Stack
{
    private readonly object[] elements;
    private int nextPush;
    private readonly int maxSize;

    public StackWithArray(int maxSize)
    {
        elements = new object[maxSize];
        nextPush = 0;
        this.maxSize = maxSize;
    }

    public override void Push(object el)
    {
        if (Full) return;
        elements[nextPush] = el;
        nextPush++;
    }

    public override void Pop()
    {
        if (!Empty)
            nextPush--;
    }

    public override object Top => !Empty ? elements[nextPush - 1] : "not possible";

    public override bool Full => nextPush >= maxSize;

    public override bool Empty => nextPush == 0;

    public override int Size => nextPush;

    public override string ToString()
    {
        var res = "Stack: ";
        for (var i = 0; i < nextPush; i++)
        {
            res += elements[i] + " ";
        }
        return res;
    }

    static void Main(string[] args)
    {
        var stack = new StackWithArray(10);

        stack.Push("sej");
        stack.Push("er");
        stack.Push("Nicolai");

        Console.WriteLine($"Top: {stack.Top}");

        stack.ToggleTop();

        Console.WriteLine("Running ToggleTop()...");

        Console.WriteLine($"Top: {stack.Top}");

        stack.ToggleTop();

        Console.WriteLine("Running ToggleTop()...");

        Console.WriteLine($"Top: {stack.Top}");

        Console.WriteLine("Emptying stack...");
        while (!stack.Empty)
        {
            Console.WriteLine(stack.Top);

            stack.Pop();
        }

        Console.ReadLine();
    }

}