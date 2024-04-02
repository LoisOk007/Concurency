namespace ModuleTestAsync;

public class Sata
{
    public int Value { get;}

    public Sata(int value)
    {
        if (value != null)
            Value = value;
    }

    public async IAsyncEnumerable<bool> IsCountTwo()
    {
        yield return Value % 2 == 0;
    }
}