using System;
using System.Collections;
using System.Collections.Generic;

[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class __z__ReadOnlySingleElementList_1<T> : IEnumerable, ICollection, IList, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{
    private readonly T _item;
    public __z__ReadOnlySingleElementList_1(T item) { _item = item; }
    public int Count => 1;
    int ICollection.Count => 1;
    int ICollection<T>.Count => 1;
    int IReadOnlyCollection<T>.Count => 1;
    bool ICollection.IsSynchronized => false;
    object ICollection.SyncRoot => this;
    bool ICollection<T>.IsReadOnly => true;
    bool IList.IsFixedSize => true;
    bool IList.IsReadOnly => true;
    T IReadOnlyList<T>.this[int index] => index == 0 ? _item : throw new IndexOutOfRangeException();
    T IList<T>.this[int index] { get => index == 0 ? _item : throw new IndexOutOfRangeException(); set => throw new NotSupportedException(); }
    object IList.this[int index] { get => index == 0 ? _item : throw new IndexOutOfRangeException(); set => throw new NotSupportedException(); }
    IEnumerator IEnumerable.GetEnumerator() { yield return _item; }
    IEnumerator<T> IEnumerable<T>.GetEnumerator() { yield return _item; }
    void ICollection.CopyTo(Array array, int index) => array.SetValue(_item, index);
    void ICollection<T>.CopyTo(T[] array, int index) => array[index] = _item;
    bool IList.Contains(object value) => EqualityComparer<object>.Default.Equals(value, _item);
    bool ICollection<T>.Contains(T item) => EqualityComparer<T>.Default.Equals(item, _item);
    int IList.IndexOf(object value) => ((IList)this).Contains(value) ? 0 : -1;
    int IList<T>.IndexOf(T item) => ((ICollection<T>)this).Contains(item) ? 0 : -1;
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
