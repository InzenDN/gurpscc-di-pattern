using System.Collections.Generic;

namespace GurpsCC.Model
{
    public interface IGurpsDatabase<T>
    {
        T this[string skillname] { get; set; }

        Dictionary<string, T> Data { get; set; }

        void Add(string key, T value);
        IEnumerator<T> GetEnumerator();
    }
}