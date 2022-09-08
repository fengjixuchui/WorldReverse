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
	public class IndexHandleObjectList<T> : IIndexHandleList<T> // TypeDefIndex: 10571
		where T : class
	{
		// Fields
		private const int DefaultCapacity = 7; // Metadata: 0x00AE7B78
		private const int MaxCapacity = 2146435071; // Metadata: 0x00AE7B7C
		private const float CapacityFactor = 1.6f; // Metadata: 0x00AE7B80
		private Queue<int> _freeIndex;
		private Dictionary<int, bool> _freeIndexDic;
		private T[] _list;
		private int _count;
		private int _realCount;
		private int _initCapacity;
	
		// Properties
		public bool IsReadOnly { get => default; }
		public int initCapacity { get => default; }
		public T this[int index] { get => default; set {} }
		public int Count { get => default; }
		public int RealCount { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 10572
		{
			// Fields
			private IndexHandleObjectList<T> list;
			private int index;
			private T current;
	
			// Properties
			object IEnumerator.Current { get => default; }
			public T Current { get => default; }
	
			// Constructors
			public Enumerator(IndexHandleObjectList<T> list) : this() {
				this.list = default;
				index = default;
				current = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public IndexHandleObjectList() {}
		public IndexHandleObjectList(int capacity) {}
	
		// Methods
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void Add(T item) {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public void Init(int capacity) {}
		public T GetFirstValid() => default;
		private int GetFreeIndex(out bool isNewIndex) {
			isNewIndex = default;
			return default;
		}
		public bool IndexRangeValid(int index) => default;
		public bool IndexValid(int index) => default;
		public int IndexAdd(T item) => default;
		public int IndexAdd(T item, bool needNewArray) => default;
		public int SwapAt(int index, T item) => default;
		public void RemoveAt(int index) {}
		public int IndexRemoveAt(int index) => default;
		public void Clear() {}
		public void BeforeRecycle() {}
		public override string ToString() => default;
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
