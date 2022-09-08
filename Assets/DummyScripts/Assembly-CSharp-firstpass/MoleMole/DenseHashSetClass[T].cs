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
	internal class DenseHashSetClass<T> : IDenseHashSetEx<T>, ICollection<T> // TypeDefIndex: 10506
		where T : class
	{
		// Fields
		private DenseHashTable<object, object> _ht;
	
		// Properties
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
	
		// Nested types
		private class HashCode : IDenseHashTableHashCode<object> // TypeDefIndex: 10507
		{
			// Fields
			private static readonly HashCode<T> _default;
	
			// Properties
			public static HashCode<T> Default { get => default; }
	
			// Constructors
			public HashCode() {}
			static HashCode() {}
	
			// Methods
			public int GetHashCode(ref object key) => default;
		}
	
		private class Key : IDenseHashTableKey<object, object> // TypeDefIndex: 10508
		{
			// Fields
			private static readonly Key<T> _default;
	
			// Properties
			public static Key<T> Default { get => default; }
	
			// Constructors
			public Key() {}
			static Key() {}
	
			// Methods
			public object GetKey(ref object value) => default;
		}
	
		private struct Enumerator : IEnumerator<T> // TypeDefIndex: 10509
		{
			// Fields
			private DenseHashTable<object, object> _it;
	
			// Properties
			object IEnumerator.Current { get => default; }
			public T Current { get => default; }
	
			// Constructors
			public Enumerator(DenseHashTable<object, object> it) : this() {
				_it = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public DenseHashSetClass() {}
		public DenseHashSetClass(int capacity) {}
	
		// Methods
		public bool Add(T value) => default;
		public bool Contains(T key) => default;
		public bool Remove(T key) => default;
		public bool TryGetValue(T key, out T value) {
			value = default;
			return default;
		}
		public void Clear() {}
		public IEnumerator<T> GetEnumerator() => default;
		void ICollection<T>.Add(T item) {}
		bool ICollection<T>.Contains(T item) => default;
		void ICollection<T>.CopyTo(T[] array, int arrayIndex) {}
		bool ICollection<T>.Remove(T item) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
