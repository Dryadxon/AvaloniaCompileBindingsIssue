using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AvaloniaDemo.Models
{
    // Dictionary<TKey, TValue> wrapper
    public class Foo<TKey, TValue> : IFoo<TKey, TValue> where TKey : notnull
    {
        private readonly IDictionary<TKey, TValue> inner;

        public Foo()
        {
            this.inner = new Dictionary<TKey, TValue>();
        }

        public TValue this[TKey key]
        {
            get => this.inner[key];
            set => this.inner[key] = value;
        }

        public ICollection<TKey> Keys => this.inner.Keys;

        public ICollection<TValue> Values => this.inner.Values;

        public int Count => this.inner.Count;

        public bool IsReadOnly => this.inner.IsReadOnly;

        public void Add(TKey key, TValue value)
        {
            this.inner.Add(key, value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            this.inner.Add(item);
        }

        public void Clear()
        {
            this.inner.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return this.inner.Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            return this.inner.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            this.inner.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return this.inner.GetEnumerator();
        }

        public bool Remove(TKey key)
        {
            return this.inner.Remove(key);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return this.inner.Remove(item);
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            return this.inner.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.inner.GetEnumerator();
        }
    }
}