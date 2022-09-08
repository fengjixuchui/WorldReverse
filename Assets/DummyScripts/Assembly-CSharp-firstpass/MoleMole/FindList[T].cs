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
	public class FindList<T> : IList<T> // TypeDefIndex: 10565
		where T : class
	{
		// Fields
		private const int DefaultCapacity = 4; // Metadata: 0x00AE7B60
		private const int MaxCapacity = 2146435071; // Metadata: 0x00AE7B64
		private const float CapacityFactor = 1.6f; // Metadata: 0x00AE7B68
		private List<T> _list;
		private Dictionary<T, int> _indexSet;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public int Capacity { get => default; set {} }
	
		// Constructors
		public FindList() {}
		public FindList(int capacity) {}
	
		// Methods
		public void EnsureCapacity(int minSize) {}
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void RemoveAt(int index) {}
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public T[] ToArray() => default;
		public bool Remove(T item) => default;
		public List<T> GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public static IList<T> Create() => default;
		public static IList<T> Create(int capacity) => default;
	}
}
