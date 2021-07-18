using System;
using System.Collections.Generic;
using System.Linq;



namespace Vheos.TraitEqualizer
{
    static public class Utility
    {
        static public T[] GetEnumValues<T>()
        => (T[])Enum.GetValues(typeof(T));
        static public T Random<T>(this IList<T> t)
        => t[TraitEqualizer.Random.Range(0, t.Count)];
        static public void Shuffle<T>(this IList<T> t)
        {
            for (int i = 0; i < t.Count - 1; ++i)
            {
                int j = TraitEqualizer.Random.Range(i, t.Count);
                T tmp = t[i];
                t[i] = t[j];
                t[j] = tmp;
            }
        }
        static public List<T> Intersect<T>(IEnumerable<IEnumerable<T>> lists)
        {
            if (lists == null || !lists.Any())
                return new List<T>();

            HashSet<T> hashSet = new HashSet<T>(lists.First());
            foreach (var list in lists.Skip(1))
                hashSet.IntersectWith(list);
            return hashSet.ToList();
        }
    }
}