/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RecycledLinkedList<T> : ICollection<T> // TypeDefIndex: 11088
{
	// Fields
	private readonly IEqualityComparer<T> _equalityComparer;
	private Node _head;
	private int _count;
	private int _version;

	// Properties
	int Count { get => default; }
	bool IsReadOnly { get => default; }
	public int count { get => default; }
	public Node first { get => default; }
	public Node last { get => default; }

	// Nested types
	public class Node : IReusable // TypeDefIndex: 11089
	{
		// Fields
		private RecycledLinkedList<T> _list;

		// Properties
		public Node<T> prev { get; set; }
		public Node<T> next { get; set; }
		public Node<T> noLoopNext { get => default; }
		public T value { get; set; }
		public RecycledLinkedList<T> list { get => default; }

		// Nested types
		public class Spawner : ISpawner<Node<T>, RecycledLinkedList<T>> // TypeDefIndex: 11090
		{
			// Constructors
			public Spawner() {}

			// Methods
			public Node<T> Spawn(RecycledLinkedList<T> param1) => default;
		}

		public class Polisher : IPolisher<Node<T>, RecycledLinkedList<T>> // TypeDefIndex: 11091
		{
			// Constructors
			public Polisher() {}

			// Methods
			public void Polish(Node<T> reused, RecycledLinkedList<T> param1) {}
		}

		// Constructors
		public Node() {} // Dummy constructor
		private Node(RecycledLinkedList<T> list) {}

		// Methods
		public void BeforeRecycle() {}
		public override string ToString() => default;
	}

	public struct Enumerator : IEnumerator<T> // TypeDefIndex: 11092
	{
		// Fields
		private readonly RecycledLinkedList<T> _list;
		private readonly int _version;
		private Node<T> _node;
		private bool _exhaust;

		// Properties
		object IEnumerator.Current { get => default; }
		public T Current { get => default; }

		// Constructors
		public Enumerator(RecycledLinkedList<T> list) : this() {
			_list = default;
			_version = default;
			_node = default;
			_exhaust = default;
		}

		// Methods
		public bool MoveNext() => default;
		public void Reset() {}
		public void Dispose() {}
	}

	// Constructors
	public RecycledLinkedList(ICollection<T> collection, IEqualityComparer<T> equalityComparer) {}
	public RecycledLinkedList(IEqualityComparer<T> equalityComparer) {}
	public RecycledLinkedList(ICollection<T> collection) {}
	public RecycledLinkedList() {}

	// Methods
	void ICollection<T>.Add(T item) {}
	void ICollection<T>.Clear() {}
	bool ICollection<T>.Contains(T item) => default;
	void ICollection<T>.CopyTo(T[] array, int arrayIndex) {}
	bool ICollection<T>.Remove(T item) => default;
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	IEnumerator IEnumerable.GetEnumerator() => default;
	public Enumerator GetEnumerator() => default;
	public Node AddFirst(T value) => default;
	public Node AddLast(T value) => default;
	public Node AddBefore(Node node, T value) => default;
	public Node AddAfter(Node node, T value) => default;
	public void Remove(Node node) {}
	public bool Remove(T value) => default;
	public bool RemoveFirst() => default;
	public bool RemoveLast() => default;
	public void Clear() {}
	public bool Contains(T value) => default;
	public Node Find(T value) => default;
	public Node FindLast(T value) => default;
	public override string ToString() => default;
	private void ValidateNode(Node node) {}
	private void InsertNodeBefore(Node front, Node behind) {}
	private void InsertNodeIntoEmpty(Node node) {}
	private void RemoveNode(Node node) {}
	private Node AllocateNode(T value) => default;
	private void DeallocateNode(Node node) {}
}

