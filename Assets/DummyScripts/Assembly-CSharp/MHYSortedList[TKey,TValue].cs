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

public class MHYSortedList<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary // TypeDefIndex: 31595
{
	// Fields
	private TKey[] keys;
	private TValue[] values;
	private int _size;
	private int version;
	private IComparer<TKey> comparer;
	private KeyList keyList;
	private ValueList valueList;
	private object _syncRoot;
	private static TKey[] emptyKeys;
	private static TValue[] emptyValues;
	private const int _defaultCapacity = 4; // Metadata: 0x00B1338C
	private const int MaxArrayLength = 2146435071; // Metadata: 0x00B13390

	// Properties
	ICollection<TKey> Keys { get => default; }
	ICollection Keys { get => default; }
	ICollection<TValue> Values { get => default; }
	ICollection Values { get => default; }
	bool IsReadOnly { get => default; }
	bool IsReadOnly { get => default; }
	bool IsFixedSize { get => default; }
	bool IsSynchronized { get => default; }
	object SyncRoot { get => default; }
	object this[object key] { get => default; set {} }
	public int Capacity { get => default; set {} }
	public IComparer<TKey> Comparer { get => default; }
	public int Count { get => default; }
	public IList<TKey> Keys { get => default; }
	public IList<TValue> Values { get => default; }
	public TValue this[TKey key] { get => default; set {} }

	// Nested types
	private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator // TypeDefIndex: 31596
	{
		// Fields
		private MHYSortedList<TKey, TValue> _MHYSortedList;
		private TKey key;
		private TValue value;
		private int index;
		private int version;
		private int getEnumeratorRetType;
		internal const int KeyValuePair = 1; // Metadata: 0x00B13394
		internal const int DictEntry = 2; // Metadata: 0x00B13398

		// Properties
		object Key { get => default; }
		DictionaryEntry Entry { get => default; }
		object IEnumerator.Current { get => default; }
		object Value { get => default; }
		public KeyValuePair<TKey, TValue> Current { get => default; }

		// Constructors
		internal Enumerator(MHYSortedList<TKey, TValue> MHYSortedList, int getEnumeratorRetType) : this() {
			_MHYSortedList = default;
			key = default;
			value = default;
			index = default;
			version = default;
			this.getEnumeratorRetType = default;
		}

		// Methods
		public void Dispose() {}
		public bool MoveNext() => default;
		void IEnumerator.Reset() {}
	}

	private sealed class MHYSortedListKeyEnumerator : IEnumerator<TKey> // TypeDefIndex: 31597
	{
		// Fields
		private MHYSortedList<TKey, TValue> _MHYSortedList;
		private int index;
		private int version;
		private TKey currentKey;

		// Properties
		object IEnumerator.Current { get => default; }
		public TKey Current { get => default; }

		// Constructors
		public MHYSortedListKeyEnumerator() {} // Dummy constructor
		internal MHYSortedListKeyEnumerator(MHYSortedList<TKey, TValue> MHYSortedList) {}

		// Methods
		public void Dispose() {}
		public bool MoveNext() => default;
		void IEnumerator.Reset() {}
	}

	private sealed class MHYSortedListValueEnumerator : IEnumerator<TValue> // TypeDefIndex: 31598
	{
		// Fields
		private MHYSortedList<TKey, TValue> _MHYSortedList;
		private int index;
		private int version;
		private TValue currentValue;

		// Properties
		object IEnumerator.Current { get => default; }
		public TValue Current { get => default; }

		// Constructors
		public MHYSortedListValueEnumerator() {} // Dummy constructor
		internal MHYSortedListValueEnumerator(MHYSortedList<TKey, TValue> MHYSortedList) {}

		// Methods
		public void Dispose() {}
		public bool MoveNext() => default;
		void IEnumerator.Reset() {}
	}

	private sealed class KeyList : IList<TKey>, ICollection // TypeDefIndex: 31599
	{
		// Fields
		private MHYSortedList<TKey, TValue> _dict;

		// Properties
		bool IsSynchronized { get => default; }
		object SyncRoot { get => default; }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public TKey this[int index] { get => default; set {} }

		// Constructors
		public KeyList() {} // Dummy constructor
		internal KeyList(MHYSortedList<TKey, TValue> dictionary) {}

		// Methods
		public void Add(TKey key) {}
		public void Clear() {}
		public bool Contains(TKey key) => default;
		public void CopyTo(TKey[] array, int arrayIndex) {}
		void ICollection.CopyTo(Array array, int arrayIndex) {}
		public void Insert(int index, TKey value) {}
		public IEnumerator<TKey> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public int IndexOf(TKey key) => default;
		public bool Remove(TKey key) => default;
		public void RemoveAt(int index) {}
	}

	private sealed class ValueList : IList<TValue>, ICollection // TypeDefIndex: 31600
	{
		// Fields
		private MHYSortedList<TKey, TValue> _dict;

		// Properties
		bool IsSynchronized { get => default; }
		object SyncRoot { get => default; }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public TValue this[int index] { get => default; set {} }

		// Constructors
		public ValueList() {} // Dummy constructor
		internal ValueList(MHYSortedList<TKey, TValue> dictionary) {}

		// Methods
		public void Add(TValue key) {}
		public void Clear() {}
		public bool Contains(TValue value) => default;
		public void CopyTo(TValue[] array, int arrayIndex) {}
		void ICollection.CopyTo(Array array, int arrayIndex) {}
		public void Insert(int index, TValue value) {}
		public IEnumerator<TValue> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public int IndexOf(TValue value) => default;
		public bool Remove(TValue value) => default;
		public void RemoveAt(int index) {}
	}

	// Constructors
	public MHYSortedList() {}
	public MHYSortedList(int capacity) {}
	public MHYSortedList(IComparer<TKey> comparer) {}
	public MHYSortedList(int capacity, IComparer<TKey> comparer) {}
	public MHYSortedList(IDictionary<TKey, TValue> dictionary) {}
	public MHYSortedList(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer) {}
	static MHYSortedList() {}

	// Methods
	public void Add(TKey key, TValue value) {}
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) {}
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) => default;
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) => default;
	void IDictionary.Add(object key, object value) {}
	private KeyList GetKeyListHelper() => default;
	private ValueList GetValueListHelper() => default;
	public void Clear() {}
	bool IDictionary.Contains(object key) => default;
	public bool ContainsKey(TKey key) => default;
	public bool ContainsValue(TValue value) => default;
	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
	void ICollection.CopyTo(Array array, int arrayIndex) {}
	private void EnsureCapacity(int min) {}
	private TValue GetByIndex(int index) => default;
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => default;
	IDictionaryEnumerator IDictionary.GetEnumerator() => default;
	IEnumerator IEnumerable.GetEnumerator() => default;
	private TKey GetKey(int index) => default;
	public int IndexOfKey(TKey key) => default;
	public int IndexOfValue(TValue value) => default;
	private void Insert(int index, TKey key, TValue value) {}
	public bool TryGetValue(TKey key, out TValue value) {
		value = default;
		return default;
	}
	public void RemoveAt(int index) {}
	public bool Remove(TKey key) => default;
	void IDictionary.Remove(object key) {}
	public void TrimExcess() {}
	private static bool IsCompatibleKey(object key) => default;
}

