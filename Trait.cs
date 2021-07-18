namespace Vheos.Tools.TraitEqualizer
{
    using System;
    public class Trait<T>
    {
        // Publics
        public string Name
        { get; private set; }
        public bool Test(T element)
        => _test(element);

        // Privates
        private Func<T, bool> _test;

        // Constructors
        public Trait(string name, Func<T, bool> test)
        {
            Name = name;
            _test = test;
        }
    }
}
