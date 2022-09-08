/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BinaryHeap<T> : IEnumerable<T> // TypeDefIndex: 11033
{
	// Fields
	private readonly IComparer<T> _comparer;
	private readonly T[] _heap;
	private readonly int _maxIndex;
	private readonly bool _maxHeap;
	private int _version;

	// Properties
	public int count { get; private set; }

	// Nested types
	public struct Enumerator : IEnumerator<T> // TypeDefIndex: 11034
	{
		// Fields
		private readonly BinaryHeap<T> _host;
		private readonly int _version;
		private int _index;

		// Properties
		object IEnumerator.Current { get => default; }
		public T Current { get => default; }

		// Constructors
		public Enumerator(BinaryHeap<T> host, int version) : this() {
			_host = default;
			_version = default;
			_index = default;
		}

		// Methods
		public bool MoveNext() => default;
		public void Reset() {}
		public void Dispose() {}
	}

	// Constructors
	public BinaryHeap() {} // Dummy constructor
	public BinaryHeap(int size, bool maxHeap, IComparer<T> comparer) {}
	public BinaryHeap(int size, bool maxHeap) {}

	// Methods
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	IEnumerator IEnumerable.GetEnumerator() => default;
	public Enumerator GetEnumerator() => default;
	public void Add(T item) {}
	public void Clear() {}
	private void Up(int index) {}
	private int Compare(T lhs, T rhs) => default;
}

