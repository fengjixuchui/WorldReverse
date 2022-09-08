/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDictionary // TypeDefIndex: 10581
	{
		// Fields
		private static int DefaultConcurrencyLevel;
		private readonly Table[] _tables;
		private IEqualityComparer<TKey> _comparer;
	
		// Properties
		bool IDictionary.IsFixedSize { get => default; }
		bool IDictionary.IsReadOnly { get => default; }
		ICollection IDictionary.Keys { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		ICollection IDictionary.Values { get => default; }
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get => default; }
		object IDictionary.this[object key] { get => default; set {} }
		public int Count { get => default; }
		public ICollection<TValue> Values { get => default; }
		public ICollection<TKey> Keys { get => default; }
		public TValue this[TKey key] { get => default; set {} }
	
		// Nested types
		private class Table // TypeDefIndex: 10582
		{
			// Fields
			public LockFreeNode<TKey, TValue> Head;
			public int Count;
	
			// Constructors
			public Table() {}
		}
	
		private class LockFreeNode // TypeDefIndex: 10583
		{
			// Fields
			public LockFreeNode<TKey, TValue> Next;
			public TKey Key;
			public TValue Value;
	
			// Constructors
			public LockFreeNode() {}
	
			// Methods
			public override string ToString() => default;
		}
	
		private class DictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 10584
		{
			// Fields
			private IEnumerator<KeyValuePair<TKey, TValue>> m_enumerator;
	
			// Properties
			public DictionaryEntry Entry { get => default; }
			public object Key { get => default; }
			public object Value { get => default; }
			public object Current { get => default; }
	
			// Constructors
			public DictionaryEnumerator() {} // Dummy constructor
			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary) {}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public ConcurrentDictionary() {}
		public ConcurrentDictionary(int concurrencyLevel) {}
		public ConcurrentDictionary(IEqualityComparer<TKey> comparer) {}
		public ConcurrentDictionary(IEqualityComparer<TKey> comparer, int concurrencyLevel) {}
		static ConcurrentDictionary() {}
	
		// Methods
		public bool TryGetValue(TKey key, out TValue value) {
			value = default;
			return default;
		}
		public void FroceAdd(TKey key, TValue value) {}
		public void Add(TKey key, TValue value) {}
		public void Clear() {}
		private int GetID(TKey key) => default;
		public bool ContainsKey(TKey key) => default;
		public bool Remove(TKey key) => default;
		public void Add(object key, object value) {}
		public bool Contains(object key) => default;
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		public void Remove(object key) {}
		public void CopyTo(Array array, int index) {}
		public KeyValuePair<TKey, TValue>[] ToArray() => default;
		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) {}
		private void CopyToEntries(DictionaryEntry[] array, int index) {}
		private void CopyToObjects(object[] array, int index) {}
		IEnumerator IEnumerable.GetEnumerator() => default;
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		private int GetCountInternal() => default;
		private ReadOnlyCollection<TKey> GetKeys() => default;
		private ReadOnlyCollection<TValue> GetValues() => default;
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) => default;
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) => default;
		public bool TryRemoveInternal(TKey key, TValue value) => default;
	}
}
