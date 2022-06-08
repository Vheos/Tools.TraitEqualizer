namespace Vheos.Tools.TraitEqualizer;
using System.Collections.Generic;

public class TraitElement<T>
{
    // Publics
    public T Value
    { get; private set; }
    public IEnumerable<Trait<T>> Traits
    { get; private set; }

    // Constructors
    public TraitElement(T value, IEnumerable<Trait<T>> traits)
    {
        Value = value;
        Traits = traits;
    }
}
