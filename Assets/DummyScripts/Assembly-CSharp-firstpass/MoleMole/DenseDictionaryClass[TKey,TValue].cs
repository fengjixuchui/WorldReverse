/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	internal class DenseDictionaryClass<TKey, TValue> : IDictionary<TKey, TValue> // TypeDefIndex: 10496
		where TKey : class
	{
		// Fields
		private DenseHashTable<object, KeyValuePair<object, TValue>> _ht;
	
		// Properties
		public TValue this[TKey key] { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public ICollection<TValue> Values { get => default; }
		public ICollection<TKey> Keys { get => default; }
	
		// Nested types
		private class HashCode : IDenseHashTableHashCode<object> // TypeDefIndex: 10497
		{
			// Fields
			private static readonly HashCode<TKey, TValue> _default;
	
			// Properties
			public static HashCode<TKey, TValue> Default { get => default; }
	
			// Constructors
			public HashCode() {}
			static HashCode() {}
	
			// Methods
			public int GetHashCode(ref object key) => default;
		}
	
		private class Key : IDenseHashTableKey<object, KeyValuePair<object, TValue>> // TypeDefIndex: 10498
		{
			// Fields
			private static readonly Key<TKey, TValue> _default;
	
			// Properties
			public static Key<TKey, TValue> Default { get => default; }
	
			// Constructors
			public Key() {}
			static Key() {}
	
			// Methods
			public object GetKey(ref KeyValuePair<object, TValue> value) => default;
		}
	
		private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator // TypeDefIndex: 10499
		{
			// Fields
			private DenseHashTable<object, KeyValuePair<object, TValue>> _it;
	
			// Properties
			object IDictionaryEnumerator.Key { get => default; }
			object IDictionaryEnumerator.Value { get => default; }
			DictionaryEntry IDictionaryEnumerator.Entry { get => default; }
			object IEnumerator.Current { get => default; }
			public KeyValuePair<TKey, TValue> Current { get => default; }
	
			// Constructors
			public Enumerator(DenseHashTable<object, KeyValuePair<object, TValue>> it) : this() {
				_it = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public DenseDictionaryClass() {}
		public DenseDictionaryClass(int capacity) {}
	
		// Methods
		public void Add(TKey key, TValue value) {}
		public bool ContainsKey(TKey key) => default;
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, out TValue value) {
			value = default;
			return default;
		}
		public void Clear() {}
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) => default;
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		private static KeyValuePair<object, TValue> AllocValue(object key, TValue value) => default;
	}
}
