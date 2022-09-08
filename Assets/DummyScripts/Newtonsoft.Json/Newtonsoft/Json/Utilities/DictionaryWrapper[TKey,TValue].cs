/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x0000000189B45780-0x0000000189B457C0
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, IWrappedDictionary // TypeDefIndex: 5328
	{
		// Fields
		private readonly IDictionary _dictionary;
		private readonly IDictionary<TKey, TValue> _genericDictionary;
		private object _syncRoot;
	
		// Properties
		public ICollection<TKey> Keys { get => default; }
		public ICollection<TValue> Values { get => default; }
		public TValue this[TKey key] { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		object IDictionary.this[object key] { get => default; set {} }
		bool IDictionary.IsFixedSize { get => default; }
		ICollection IDictionary.Keys { get => default; }
		ICollection IDictionary.Values { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		public object UnderlyingDictionary { get => default; }
	
		// Nested types
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator // TypeDefIndex: 5329
		{
			// Fields
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
	
			// Properties
			public DictionaryEntry Entry { get => default; }
			public object Key { get => default; }
			public object Value { get => default; }
			public object Current { get => default; }
	
			// Constructors
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) : this() {
				_e = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public DictionaryWrapper() {} // Dummy constructor
	
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
		void IDictionary.Add(object key, object value) {}
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		bool IDictionary.Contains(object key) => default;
		public void Remove(object key) {}
		void ICollection.CopyTo(Array array, int index) {}
	}
}
