using System.Collections;
using System.Collections.Generic;

namespace GurpsCC.Model
{
    public class GurpsDatabase<T> : IEnumerable<T>, IGurpsDatabase<T>
    {
        public Dictionary<string, T> Data { get; set; }
        public T this[string skillname]
        {
            get { return Data[skillname]; }
            set { Data[skillname] = value; }
        }

        public GurpsDatabase()
        {
            Data = new Dictionary<string, T>();
        }

        public void Add(string key, T value)
        {
            Data.Add(key, value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Data.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
