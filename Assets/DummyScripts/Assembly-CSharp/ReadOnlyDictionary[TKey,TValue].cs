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

internal sealed class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue> // TypeDefIndex: 26307
{
	// Fields
	private readonly IDictionary<TKey, TValue> wrapped;

	// Properties
	public ICollection<TKey> Keys { get => default; }
	public ICollection<TValue> Values { get => default; }
	public TValue this[TKey key] { get => default; set {} }
	public int Count { get => default; }
	public bool IsReadOnly { get => default; }

	// Constructors
	public ReadOnlyDictionary() {} // Dummy constructor
	public ReadOnlyDictionary(IDictionary<TKey, TValue> wrapped) {}

	// Methods
	public void Add(TKey key, TValue value) {}
	public bool ContainsKey(TKey key) => default;
	public bool Remove(TKey key) => default;
	public bool TryGetValue(TKey key, out TValue value) {
		value = default;
		return default;
	}
	public void Add(KeyValuePair<TKey, TValue> item) {}
	public void Clear() {}
	public bool Contains(KeyValuePair<TKey, TValue> item) => default;
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
	public bool Remove(KeyValuePair<TKey, TValue> item) => default;
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
	IEnumerator IEnumerable.GetEnumerator() => default;
	public override bool Equals(object obj) => default;
	public override int GetHashCode() => default;
	public override string ToString() => default;
}

