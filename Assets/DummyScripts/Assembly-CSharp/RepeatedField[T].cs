/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class RepeatedField<T> : IList<T>, IList // TypeDefIndex: 26308
{
	// Properties
	bool IsFixedSize { get; }
	bool IsSynchronized { get; }
	object SyncRoot { get; }
	object this[int index] { get => default; set {} }
	public abstract T this[int index] { get => default; set {} }
	public abstract int Count { get; }
	public abstract bool IsReadOnly { get; }

	// Constructors
	protected RepeatedField() {}

	// Methods
	public abstract void Add(T item);
	public abstract void AddRange(IEnumerable<T> values);
	public abstract void Clear();
	public abstract void Reset();
	public abstract bool Contains(T item);
	public abstract IEnumerator<T> GetEnumerator();
	public abstract int IndexOf(T item);
	public abstract void Insert(int index, T item);
	public abstract bool Remove(T item);
	public abstract void RemoveAt(int index);
	IEnumerator IEnumerable.GetEnumerator() => default;
	public abstract void CopyTo(T[] array, int arrayIndex);
	int IList.Add(object value) => default;
	bool IList.Contains(object value) => default;
	int IList.IndexOf(object value) => default;
	void IList.Insert(int index, object value) {}
	void IList.Remove(object value) {}
	public abstract void CopyTo(Array array, int index);
	public override string ToString() => default;
}

