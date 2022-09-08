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

namespace PigeonCoopToolkit.Utillities
{
	public class CircularBuffer<T> : IList<T> // TypeDefIndex: 9461
	{
		// Fields
		private T[] _buffer;
		private int _position;
		private long _version;
	
		// Properties
		bool ICollection<T>.IsReadOnly { get => default; }
		public T this[int index] { get => default; set {} }
		public int Capacity { get; private set; }
		public int Count { get; private set; }
	
		// Constructors
		public CircularBuffer() {} // Dummy constructor
		public CircularBuffer(int capacity) {}
	
		// Methods
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator<T> GetEnumerator() => default;
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public bool Remove(T item) => default;
		public void RemoveAt(int index) {}
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
