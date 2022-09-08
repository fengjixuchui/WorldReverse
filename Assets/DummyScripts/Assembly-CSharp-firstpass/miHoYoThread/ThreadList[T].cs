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

namespace miHoYoThread
{
	public class ThreadList<T> : IList<T> // TypeDefIndex: 8992
	{
		// Fields
		private const int MIN_SIZE = 0; // Metadata: 0x00AE5025
		private T[] _buffer;
		private int _count;
		private static readonly bool _isValueType;
	
		// Properties
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public T this[int i] { get => default; set {} }
	
		// Nested types
		public static class NoVirt // TypeDefIndex: 8993
		{
			// Methods
			public static int Count(ThreadList<T> fasterList) => default;
			public static T[] ToArrayFast(ThreadList<T> fasterList, out int count) {
				count = default;
				return default;
			}
			internal static T[] ToArrayFast(ThreadList<T> fasterList) => default;
			public static void FastSet(ThreadList<T> fasterList, int index, T item) {}
		}
	
		// Constructors
		public ThreadList() {}
		public ThreadList(int initialSize = 0 /* Metadata: 0x00AE5021 */) {}
		public ThreadList(T[] collection) {}
		public ThreadList(ICollection<T> collection) {}
		public ThreadList(ICollection<T> collection, int extraSize) {}
		public ThreadList(ThreadList<T> listCopy) {}
		static ThreadList() {}
	
		// Methods
		public void Add(T item) {}
		public void AddRef(ref T item) {}
		public static ThreadList<T> PreFill<U>(int initialSize)
			where U : T, new() => default;
		public void AddRange(IEnumerable<T> items, int count) {}
		public void AddRange(IEnumerator<T> items, int count) {}
		public void AddRange(ICollection<T> items) {}
		public void AddRange(ThreadList<T> items) {}
		public void AddRange(T[] items, int count) {}
		public void AddRange(T[] items) {}
		public ThreadReadOnlyList<T> AsReadOnly() => default;
		public void FastClear() {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public ThreadListEnumerator<T> GetEnumerator() => default;
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void Release() {}
		public bool Remove(T item) => default;
		public void RemoveAt(int index) {}
		public void Resize(int newSize) {}
		public void Sort(IComparer<T> comparer) {}
		public void Sort() {}
		public T[] ToArray() => default;
		public T[] ToArrayFast() => default;
		public bool UnorderedRemove(T item) => default;
		public bool UnorderedRemoveAt(int index) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		private void AllocateMore() {}
		private void AllocateMore(int newSize) {}
		public void Trim() {}
		public void TrimCount(int newCount) {}
		public bool Reuse<U>(int index, out U result)
			where U : class, T {
			result = default;
			return default;
		}
		public void UnorderedRemoveRange(int groupStart, int groupEnd) {}
		public void ResizeIfSmaller(int cellCount) {}
	}
}
