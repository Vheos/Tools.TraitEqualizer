namespace Vheos.Tools.TraitEqualizer;

public class Trait<T>
{
    // Publics
    public string Name
    { get; private set; }
    public bool Test(T element)
    => _test(element);

    // Privates
    private readonly Func<T, bool> _test;

    // Constructors
    public Trait(string name, Func<T, bool> test)
    {
        Name = name;
        _test = test;
    }
}
