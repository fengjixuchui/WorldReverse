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
	public struct ThreadReadOnlyList<T> : IList<T> // TypeDefIndex: 8994
	{
		// Fields
		private readonly ThreadList<T> _list;
	
		// Properties
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public ThreadReadOnlyList(ThreadList<T> list) : this() {
			_list = default;
		}
	
		// Methods
		public ThreadListEnumerator<T> GetEnumerator() => default;
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void RemoveAt(int index) {}
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
