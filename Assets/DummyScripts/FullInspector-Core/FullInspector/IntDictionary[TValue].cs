/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullInspector.Internal;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	internal class IntDictionary<TValue> : IDictionary<int, TValue> // TypeDefIndex: 4803
	{
		// Fields
		private List<fiOption<TValue>> _positives;
		private Dictionary<int, TValue> _negatives;
	
		// Properties
		public ICollection<int> Keys { get => default; }
		public ICollection<TValue> Values { get => default; }
		public TValue this[int key] { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
	
		// Constructors
		public IntDictionary() {}
	
		// Methods
		public void Add(int key, TValue value) {}
		public bool ContainsKey(int key) => default;
		public bool Remove(int key) => default;
		public bool TryGetValue(int key, out TValue value) {
			value = default;
			return default;
		}
		public void Add(KeyValuePair<int, TValue> item) {}
		public void Clear() {}
		public bool Contains(KeyValuePair<int, TValue> item) => default;
		public void CopyTo(KeyValuePair<int, TValue>[] array, int arrayIndex) {}
		public bool Remove(KeyValuePair<int, TValue> item) => default;
		public IEnumerator<KeyValuePair<int, TValue>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
