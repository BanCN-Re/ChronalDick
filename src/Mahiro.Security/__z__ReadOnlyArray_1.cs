using System;
using System.Collections;
using System.Collections.Generic;

[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class __z__ReadOnlyArray_1<T> : IEnumerable, ICollection, IList, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{
    private readonly T[] _items;
    public __z__ReadOnlyArray_1(T[] items) { _items = items ?? Array.Empty<T>(); }
    public int Count => _items.Length;
    int ICollection.Count => _items.Length;
    int ICollection<T>.Count => _items.Length;
    int IReadOnlyCollection<T>.Count => _items.Length;
    bool ICollection.IsSynchronized => false;
    object ICollection.SyncRoot => _items;
    bool ICollection<T>.IsReadOnly => true;
    bool IList.IsFixedSize => true;
    bool IList.IsReadOnly => true;
    T IReadOnlyList<T>.this[int index] => _items[index];
    T IList<T>.this[int index] { get => _items[index]; set => throw new NotSupportedException(); }
    object IList.this[int index] { get => _items[index]; set => throw new NotSupportedException(); }
    IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => ((IEnumerable<T>)_items).GetEnumerator();
    void ICollection.CopyTo(Array array, int index) => _items.CopyTo(array, index);
    void ICollection<T>.CopyTo(T[] array, int index) => _items.CopyTo(array, index);
    bool IList.Contains(object value) => ((IList)_items).Contains(value);
    bool ICollection<T>.Contains(T item) => ((ICollection<T>)_items).Contains(item);
    int IList.IndexOf(object value) => ((IList)_items).IndexOf(value);
    int IList<T>.IndexOf(T item) => ((IList<T>)_items).IndexOf(item);
    int IList.Add(object value) => throw new NotSupportedException();
    void ICollection<T>.Add(T item) => throw new NotSupportedException();
    void IList.Insert(int index, object value) => throw new NotSupportedException();
    void IList<T>.Insert(int index, T item) => throw new NotSupportedException();
    void IList.Remove(object value) => throw new NotSupportedException();
    bool ICollection<T>.Remove(T item) => throw new NotSupportedException();
    void ICollection<T>.Clear() => throw new NotSupportedException();
    void IList.Clear() => throw new NotSupportedException();
    void IList.RemoveAt(int index) => throw new NotSupportedException();
    void IList<T>.RemoveAt(int index) => throw new NotSupportedException();
}
