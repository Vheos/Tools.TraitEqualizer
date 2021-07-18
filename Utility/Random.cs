using System;
using System.Collections.Generic;
using System.Linq;
using Vheos.Extensions.Math;



namespace Vheos.TraitEqualizer
{
    static public class Random
    {
        // Publics
        static public float Value01
        => (float)_random.NextDouble();
        static public int Range(int fromInclusive, int toExclusive)
        => Value01.MapFrom01(fromInclusive, toExclusive).RoundDown();

        // Privates
        static private int _seed;
        static private System.Random _random;
        static private void Reseed()
        => _random = new System.Random(_seed);

        // Initializers
        static public void Initialize()
        {
            _seed = (int)DateTime.Now.Ticks;
            Reseed();
        }
        static public void Initialize(int seed)
        {
            _seed = seed;
            Reseed();
        }
    }
}